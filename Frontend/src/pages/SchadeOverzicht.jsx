import React, { useState, useEffect } from 'react';
import '../styles/SchadeOverzicht.css';

const SchadeOverzicht = () => {
    const [schades, setSchades] = useState([]);
    const [error, setError] = useState('');

    useEffect(() => {
        fetch('/api/schade')
            .then(response => {
                if (!response.ok) {
                    throw new Error('Netwerkrespons was niet OK');
                }
                return response.json();
            })
            .then(data => setSchades(data))
            .catch(err => setError('Fout bij het ophalen van schades: ' + err.message));
    }, []);

    const handleStatusChange = (id, status) => {
        fetch(`/api/schade/${id}/status`, {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(status),
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error('Status kon niet worden bijgewerkt');
                }
                return response.json();
            })
            .then(updatedSchade => {
                setSchades(prev =>
                    prev.map(schade =>
                        schade.schadeId === id ? { ...schade, status: updatedSchade.status } : schade
                    )
                );
            })
            .catch(err => setError('Fout bij het bijwerken van status: ' + err.message));
    };

    const handleAddOpmerking = (id, opmerking) => {
        fetch(`/api/schade/${id}/opmerking`, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(opmerking),
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error('Opmerking kon niet worden toegevoegd');
                }
                return response.json();
            })
            .then(updatedSchade => {
                setSchades(prev =>
                    prev.map(schade =>
                        schade.schadeId === id ? { ...schade, reparatieOpmerkingen: updatedSchade.reparatieOpmerkingen } : schade
                    )
                );
            })
            .catch(err => setError('Fout bij het toevoegen van opmerking: ' + err.message));
    };

    if (error) {
        return <div className="error">{error}</div>;
    }

    return (
        <div className="schade-overzicht">
            <h1>Schademeldingen</h1>
            {schades.map(schade => (
                <div key={schade.schadeId} className="schade-card">
                    <h2>{schade.voertuigId}</h2>
                    <p>Beschrijving: {schade.beschrijving}</p>
                    <p>Datum: {new Date(schade.schadeDatum).toLocaleDateString()}</p>
                    <div className="foto-container">
                        {schade.fotoUrls.map((url, index) => (
                            <img key={index} src={url} alt={`Schadefoto ${index + 1}`} />
                        ))}
                    </div>
                    <p>Status: {schade.status}</p>
                    <button onClick={() => handleStatusChange(schade.schadeId, 'In Reparatie')}>
                        In Reparatie
                    </button>
                    <button onClick={() => handleStatusChange(schade.schadeId, 'Gerepareerd')}>
                        Gerepareerd
                    </button>
                    <h3>Opmerkingen</h3>
                    <p>{schade.reparatieOpmerkingen}</p>
                    <textarea
                        placeholder="Voeg een opmerking toe"
                        onBlur={e => handleAddOpmerking(schade.schadeId, e.target.value)}
                    />
                </div>
            ))}
        </div>
    );
};

export default SchadeOverzicht;

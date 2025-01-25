import React, { useState, useEffect } from 'react';
import '../styles/SchadeOverzicht.css';

const SchadeOverzicht = () => {
    const [schades, setSchades] = useState([]);
    const [error, setError] = useState('');

    // Ophalen van schademeldingen
    useEffect(() => {
        console.log('SchadeOverzicht component geladen');
        fetch('/api/schade')
            .then(response => {
                if (!response.ok) {
                    throw new Error('Netwerkrespons was niet OK');
                }
                return response.json();
            })
            .then(data => {
                console.log('Schades:', data);
                setSchades(data);
            })
            .catch(err => {
                console.error('Fout bij het ophalen van schades:', err);
                setError('Fout bij het ophalen van schades: ' + err.message);
            });
    }, []);

    // Status bijwerken
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
            .catch(err => {
                console.error('Fout bij het bijwerken van status:', err);
                setError('Fout bij het bijwerken van status: ' + err.message);
            });
    };

    // Opmerking toevoegen
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
            .catch(err => {
                console.error('Fout bij het toevoegen van opmerking:', err);
                setError('Fout bij het toevoegen van opmerking: ' + err.message);
            });
    };

    if (error) {
        return <div className="error">{error}</div>;
    }

    if (schades.length === 0) {
        return <div className="schade-overzicht">Geen schademeldingen gevonden.</div>;
    }

    return (
        <div className="schade-overzicht">
            <h1>Schademeldingen</h1>
            {schades.map(schade => (
                <div key={schade.schadeId} className="schade-card">
                    <h2>Voertuig ID: {schade.voertuigId}</h2>
                    <p><strong>Beschrijving:</strong> {schade.beschrijving}</p>
                    <p><strong>Datum:</strong> {new Date(schade.schadeDatum).toLocaleDateString()}</p>
                    <div className="foto-container">
                        {schade.fotoUrls.map((url, index) => (
                            <img key={index} src={url} alt={`Schadefoto ${index + 1}`} />
                        ))}
                    </div>
                    <p><strong>Status:</strong> {schade.status}</p>
                    <div className="status-buttons">
                        <button className="btn-in-reparatie" onClick={() => handleStatusChange(schade.schadeId, 'In Reparatie')}>
                            In Reparatie
                        </button>
                        <button className="btn-gerepareerd" onClick={() => handleStatusChange(schade.schadeId, 'Gerepareerd')}>
                            Gerepareerd
                        </button>
                    </div>
                    <div className="opmerkingen">
                        <h3>Opmerkingen</h3>
                        <p>{schade.reparatieOpmerkingen}</p>
                        <textarea
                            placeholder="Voeg een opmerking toe"
                            onBlur={e => handleAddOpmerking(schade.schadeId, e.target.value)}
                        />
                    </div>
                </div>
            ))}
        </div>
    );
};

export default SchadeOverzicht;

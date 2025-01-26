import React, { useState, useEffect } from 'react';
import '../styles/SchadeOverzicht.css';

const SchadeOverzicht = () => {
    const [schades, setSchades] = useState([]);
    const [error, setError] = useState('');

    useEffect(() => {
        fetch('/api/schade')
            .then(response => {
                if (!response.ok) {
                    throw new Error(`Netwerkfout: ${response.status} ${response.statusText}`);
                }
                return response.json();
            })
            .then(data => setSchades(data))
            .catch(err => setError(`Fout bij het ophalen van schades: ${err.message}`));
    }, []);

    const handleStatusChange = (id, status) => {
        fetch(`/api/schade/${id}/status`, {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(status),
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error(`Fout bij het bijwerken van status: ${response.status}`);
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
            .catch(err => setError(err.message));
    };

    const handleAddOpmerking = (id, opmerking) => {
        if (!opmerking.trim()) {
            setError('Opmerking mag niet leeg zijn.');
            return;
        }

        fetch(`/api/schade/${id}/opmerking`, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(opmerking),
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error(`Fout bij het toevoegen van opmerking: ${response.status}`);
                }
                return response.json();
            })
            .then(updatedSchade => {
                setSchades(prev =>
                    prev.map(schade =>
                        schade.schadeId === id
                            ? { ...schade, reparatieOpmerkingen: updatedSchade.reparatieOpmerkingen }
                            : schade
                    )
                );
            })
            .catch(err => setError(err.message));
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
                    <h2>Voertuig: {schade.voertuigNaam || `ID: ${schade.voertuigId}`}</h2>
                    <p><strong>Schademelder:</strong> {schade.schademelder || 'Onbekend'}</p>
                    <p><strong>Beschrijving:</strong> {schade.beschrijving}</p>
                    <p><strong>Datum:</strong> {new Date(schade.schadeDatum).toLocaleDateString()}</p>
                    <div className="foto-container">
                        {schade.fotoUrls && schade.fotoUrls.length > 0 ? (
                            schade.fotoUrls.map((url, index) => (
                                <img key={index} src={url} alt={`Schadefoto ${index + 1}`} />
                            ))
                        ) : (
                            <p>Geen foto's beschikbaar</p>
                        )}
                    </div>
                    <p><strong>Status:</strong> {schade.status}</p>
                    <button onClick={() => handleStatusChange(schade.schadeId, 'In Reparatie')}>
                        In Reparatie
                    </button>
                    <button onClick={() => handleStatusChange(schade.schadeId, 'Gerepareerd')}>
                        Gerepareerd
                    </button>
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

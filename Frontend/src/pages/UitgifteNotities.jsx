// src/pages/UitgifteNotities.jsx

import React, { useState } from 'react';
import '../styles/UitgifteNotities.css';

const VehicleIssuanceNotes = () => {
    const [notes, setNotes] = useState({
        condition: '',
        mileage: '',
        fuelLevel: '',
        additionalNotes: '',
    });

    const [confirmation, setConfirmation] = useState(null);

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setNotes((prev) => ({ ...prev, [name]: value }));
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        // Simuleer bevestiging en opslag van notities
        setConfirmation('De opmerkingen zijn succesvol opgeslagen en gekoppeld aan de huurgeschiedenis.');
        setNotes({ condition: '', mileage: '', fuelLevel: '', additionalNotes: '' });
    };

    return (
        <div className="vehicle-issuance-notes" style={{ marginLeft: '1rem' }}>
            <h1>Notities bij Voertuiguitgifte</h1>

            <form onSubmit={handleSubmit}>
                <label>
                    Conditie van het voertuig:
                    <input
                        type="text"
                        name="condition"
                        value={notes.condition}
                        onChange={handleInputChange}
                        placeholder="Bijv. Geen zichtbare schade"
                        required
                    />
                </label>

                <label>
                    Kilometerstand:
                    <input
                        type="number"
                        name="mileage"
                        value={notes.mileage}
                        onChange={handleInputChange}
                        placeholder="Bijv. 12000"
                        required
                    />
                </label>

                <label>
                    Brandstofniveau:
                    <input
                        type="text"
                        name="fuelLevel"
                        value={notes.fuelLevel}
                        onChange={handleInputChange}
                        placeholder="Bijv. Halfvol"
                        required
                    />
                </label>

                <label>
                    Aanvullende opmerkingen:
                    <textarea
                        name="additionalNotes"
                        value={notes.additionalNotes}
                        onChange={handleInputChange}
                        placeholder="Voeg extra opmerkingen toe..."
                        rows="4"
                    />
                </label>

                <button type="submit" className="submit-button">
                    Opslaan
                </button>
            </form>

            {confirmation && <p className="confirmation-message">{confirmation}</p>}
        </div>
    );
};

export default VehicleIssuanceNotes;

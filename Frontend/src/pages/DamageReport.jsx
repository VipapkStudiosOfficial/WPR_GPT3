// src/pages/DamageReport.jsx

import React, { useState } from 'react';
import '../styles/DamageReport.css';

const DamageReport = () => {
    const [damageDetails, setDamageDetails] = useState({
        description: '',
        reservationId: '',
        photos: [],
    });

    const [confirmation, setConfirmation] = useState(null);

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setDamageDetails((prev) => ({ ...prev, [name]: value }));
    };

    const handleFileChange = (e) => {
        const files = Array.from(e.target.files);
        setDamageDetails((prev) => ({ ...prev, photos: [...prev.photos, ...files] }));
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        // Simuleer bevestiging van melding
        setConfirmation('Schademelding succesvol verzonden. Een bevestigingsmail is verstuurd.');
        setDamageDetails({ description: '', reservationId: '', photos: [] });
    };

    return (
        <div className="damage-report" style={{ marginLeft: '1rem' }}>
            <h1>Schade Melden</h1>

            <form onSubmit={handleSubmit}>
                <label>
                    Reserveringsnummer:
                    <input
                        type="text"
                        name="reservationId"
                        value={damageDetails.reservationId}
                        onChange={handleInputChange}
                        placeholder="Voer reserveringsnummer in"
                        required
                    />
                </label>

                <label>
                    Beschrijving van de schade:
                    <textarea
                        name="description"
                        value={damageDetails.description}
                        onChange={handleInputChange}
                        placeholder="Beschrijf de schade..."
                        rows="4"
                        required
                    />
                </label>

                <label>
                    Foto's van de schade:
                    <input
                        type="file"
                        multiple
                        accept="image/*"
                        onChange={handleFileChange}
                        aria-label="Upload foto's van de schade"
                    />
                </label>

                <button type="submit" className="submit-button">
                    Verzenden
                </button>
            </form>

            {confirmation && <p className="confirmation-message">{confirmation}</p>}

            {damageDetails.photos.length > 0 && (
                <div className="photo-preview">
                    <h2>Voorbeeld van geüploade foto's:</h2>
                    <div className="photos">
                        {damageDetails.photos.map((photo, index) => (
                            <img
                                key={index}
                                src={URL.createObjectURL(photo)}
                                alt={`Schade voorbeeld ${index + 1}`}
                                className="photo-preview-image"
                            />
                        ))}
                    </div>
                </div>
            )}
        </div>
    );
};

export default DamageReport;

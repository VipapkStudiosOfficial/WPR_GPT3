// src/pages/BusinessAccountInstellingen.jsx

import React, { useState } from 'react';
import '../styles/AccountInstellingen.css';

const BusinessAccountSettings = () => {
    const [businessData, setBusinessData] = useState({
        bedrijfsnaam: 'Example BV',
        adres: 'Kerkstraat 12, Amsterdam',
        kvkNummer: '12345678',
        email: 'contact@example.com',
        telefoon: '0612345678',
    });

    const [bewerkModus, setBewerkModus] = useState(false);

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setBusinessData((prevData) => ({ ...prevData, [name]: value }));
    };

    const handleSave = () => {
        setBewerkModus(false);
        alert('Bedrijfsaccount succesvol bijgewerkt!');
    };

    const handleDeleteAccount = () => {
        if (window.confirm('Weet u zeker dat u het bedrijfsaccount wilt verwijderen? Deze actie kan niet ongedaan worden gemaakt.')) {
            alert('Bedrijfsaccount succesvol verwijderd!');
            // Simuleer accountverwijdering
        }
    };

    return (
        <div className="account-settings" aria-label="Instellingen van het bedrijfsaccount">
            <h1>Bedrijfsaccountinstellingen</h1>
            {bewerkModus ? (
                <div className="form-container">
                    <label htmlFor="bedrijfsnaam">
                        Bedrijfsnaam:
                        <input
                            id="bedrijfsnaam"
                            type="text"
                            name="bedrijfsnaam"
                            value={businessData.bedrijfsnaam}
                            onChange={handleInputChange}
                            aria-label="Voer de bedrijfsnaam in"
                        />
                    </label>
                    <label htmlFor="adres">
                        Adres:
                        <input
                            id="adres"
                            type="text"
                            name="adres"
                            value={businessData.adres}
                            onChange={handleInputChange}
                            aria-label="Voer het adres in"
                        />
                    </label>
                    <label htmlFor="kvkNummer">
                        KvK-nummer:
                        <input
                            id="kvkNummer"
                            type="text"
                            name="kvkNummer"
                            value={businessData.kvkNummer}
                            onChange={handleInputChange}
                            aria-label="Voer het KvK-nummer in"
                        />
                    </label>
                    <label htmlFor="email">
                        E-mail:
                        <input
                            id="email"
                            type="email"
                            name="email"
                            value={businessData.email}
                            onChange={handleInputChange}
                            aria-label="Voer het e-mailadres in"
                        />
                    </label>
                    <label htmlFor="telefoon">
                        Telefoonnummer:
                        <input
                            id="telefoon"
                            type="text"
                            name="telefoon"
                            value={businessData.telefoon}
                            onChange={handleInputChange}
                            aria-label="Voer het telefoonnummer in"
                        />
                    </label>
                    <button onClick={handleSave} className="save-button" aria-label="Sla wijzigingen op">Opslaan</button>
                </div>
            ) : (
                <div className="user-info">
                    <p><strong>Bedrijfsnaam:</strong> {businessData.bedrijfsnaam}</p>
                    <p><strong>Adres:</strong> {businessData.adres}</p>
                    <p><strong>KvK-nummer:</strong> {businessData.kvkNummer}</p>
                    <p><strong>E-mail:</strong> {businessData.email}</p>
                    <p><strong>Telefoonnummer:</strong> {businessData.telefoon}</p>
                    <button onClick={() => setBewerkModus(true)} className="edit-button" aria-label="Bewerk gegevens">Bewerken</button>
                </div>
            )}
            <button onClick={handleDeleteAccount} className="delete-button" aria-label="Verwijder account">Bedrijfsaccount verwijderen</button>
        </div>
    );
};

export default BusinessAccountSettings;

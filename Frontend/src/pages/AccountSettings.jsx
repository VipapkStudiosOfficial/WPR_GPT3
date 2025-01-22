// src/pages/AccountSettings.jsx

import React, { useState } from 'react';
import '../styles/AccountSettings.css';

const AccountSettings = () => {
    const [userData, setUserData] = useState({
        naam: 'Jan Jansen',
        email: 'jan.jansen@example.com',
        adres: 'Hoofdstraat 123',
        telefoon: '0612345678',
    });

    const [bewerkModus, setBewerkModus] = useState(false);

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setUserData((prevData) => ({ ...prevData, [name]: value }));
    };

    const handleSave = () => {
        setBewerkModus(false);
        alert('Accountgegevens succesvol bijgewerkt!');
    };

    const handleDeleteAccount = () => {
        if (window.confirm('Weet u zeker dat u uw account wilt verwijderen? Deze actie kan niet ongedaan worden gemaakt.')) {
            alert('Account succesvol verwijderd!');
            // Simuleer accountverwijdering
        }
    };

    return (
        <div className="account-settings" aria-label="Instellingen van het account">
            <h1>Accountinstellingen</h1>
            {bewerkModus ? (
                <div className="form-container">
                    <label htmlFor="naam">
                        Naam:
                        <input
                            id="naam"
                            type="text"
                            name="naam"
                            value={userData.naam}
                            onChange={handleInputChange}
                            aria-label="Voer uw naam in"
                        />
                    </label>
                    <label htmlFor="email">
                        E-mail:
                        <input
                            id="email"
                            type="email"
                            name="email"
                            value={userData.email}
                            onChange={handleInputChange}
                            aria-label="Voer uw e-mailadres in"
                        />
                    </label>
                    <label htmlFor="adres">
                        Adres:
                        <input
                            id="adres"
                            type="text"
                            name="adres"
                            value={userData.adres}
                            onChange={handleInputChange}
                            aria-label="Voer uw adres in"
                        />
                    </label>
                    <label htmlFor="telefoon">
                        Telefoonnummer:
                        <input
                            id="telefoon"
                            type="text"
                            name="telefoon"
                            value={userData.telefoon}
                            onChange={handleInputChange}
                            aria-label="Voer uw telefoonnummer in"
                        />
                    </label>
                    <button onClick={handleSave} className="save-button" aria-label="Sla wijzigingen op">Opslaan</button>
                </div>
            ) : (
                <div className="user-info">
                    <p><strong>Naam:</strong> {userData.naam}</p>
                    <p><strong>E-mail:</strong> {userData.email}</p>
                    <p><strong>Adres:</strong> {userData.adres}</p>
                    <p><strong>Telefoon:</strong> {userData.telefoon}</p>
                    <button onClick={() => setBewerkModus(true)} className="edit-button" aria-label="Bewerk gegevens">Bewerken</button>
                </div>
            )}
            <button onClick={handleDeleteAccount} className="delete-button" aria-label="Verwijder account">Account verwijderen</button>
        </div>
    );
};

export default AccountSettings;

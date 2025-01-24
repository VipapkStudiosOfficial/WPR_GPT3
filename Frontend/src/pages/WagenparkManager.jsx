// src/pages/WagenparkManager.jsx

import React, { useState } from 'react';
import '../styles/WagenparkManager.css';

const FleetManager = () => {
    const [employees, setEmployees] = useState([
        { id: 1, email: 'employee1@company.com' },
        { id: 2, email: 'employee2@company.com' },
    ]);

    const [newEmail, setNewEmail] = useState('');
    const [message, setMessage] = useState({ text: '', type: '' });

    const handleAddEmployee = () => {
        const emailRegex = /^[^@\s]+@[^@\s]+\.[^@\s]+$/;
        if (!emailRegex.test(newEmail)) {
            setMessage({ text: 'Voer een geldig e-mailadres in.', type: 'error' });
            return;
        }
        if (!newEmail.endsWith('@company.com')) {
            setMessage({ text: 'Alleen bedrijfse-mailadressen zijn toegestaan.', type: 'error' });
            return;
        }
        if (employees.some((employee) => employee.email === newEmail)) {
            setMessage({ text: 'Dit e-mailadres is al toegevoegd.', type: 'error' });
            return;
        }
        setEmployees((prev) => [...prev, { id: Date.now(), email: newEmail }]);
        setNewEmail('');
        setMessage({ text: 'Medewerker succesvol toegevoegd.', type: 'success' });
    };

    const handleRemoveEmployee = (id) => {
        setEmployees((prev) => prev.filter((employee) => employee.id !== id));
        setMessage({ text: 'Medewerker succesvol verwijderd.', type: 'success' });
    };

    return (
        <div className="fleet-manager" aria-label="Beheer van zakelijke huurders">
            <h1>Zakelijke Huurders Beheren</h1>
            <div className="form-container">
                <label htmlFor="email">Medewerker E-mailadres:</label>
                <input
                    id="email"
                    type="email"
                    value={newEmail}
                    onChange={(e) => setNewEmail(e.target.value)}
                    aria-label="Voer het e-mailadres van de nieuwe medewerker in"
                />
                <button onClick={handleAddEmployee} className="add-button" aria-label="Voeg medewerker toe">
                    Toevoegen
                </button>
            </div>
            {message.text && (
                <p className={`message ${message.type}`} role="alert">{message.text}</p>
            )}
            <div className="employee-list">
                <h2>Medewerkerslijst</h2>
                <ul>
                    {employees.map((employee) => (
                        <li key={employee.id}>
                            {employee.email}
                            <button
                                onClick={() => handleRemoveEmployee(employee.id)}
                                className="remove-button"
                                aria-label={`Verwijder medewerker met e-mailadres ${employee.email}`}
                            >
                                Verwijderen
                            </button>
                        </li>
                    ))}
                </ul>
            </div>
        </div>
    );
};

export default FleetManager;

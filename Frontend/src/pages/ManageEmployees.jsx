// src/pages/ManageEmployees.jsx

import React, { useState } from 'react';
import '../styles/ManageEmployees.css';

const ManageEmployees = () => {
    const [employees, setEmployees] = useState([
        { id: 1, email: 'medewerker1@bedrijf.com' },
        { id: 2, email: 'medewerker2@bedrijf.com' },
    ]);

    const [newEmail, setNewEmail] = useState('');
    const [message, setMessage] = useState('');
    const maxEmployees = 5; // Maximum aantal medewerkers op basis van abonnementstype

    const handleAddEmployee = () => {
        const emailRegex = /^[^@\s]+@[^@\s]+\.[^@\s]+$/;
        if (!emailRegex.test(newEmail)) {
            setMessage('Voer een geldig e-mailadres in.');
            return;
        }
        if (!newEmail.endsWith('@bedrijf.com')) {
            setMessage('Alleen zakelijke e-mailadressen zijn toegestaan.');
            return;
        }
        if (employees.length >= maxEmployees) {
            setMessage('Het maximum aantal medewerkers is bereikt.');
            return;
        }
        if (employees.some((emp) => emp.email === newEmail)) {
            setMessage('Deze medewerker is al toegevoegd.');
            return;
        }
        setEmployees((prev) => [...prev, { id: Date.now(), email: newEmail }]);
        setMessage(`Medewerker ${newEmail} succesvol toegevoegd.`);
        setNewEmail('');
    };

    const handleRemoveEmployee = (id) => {
        const removedEmployee = employees.find((emp) => emp.id === id);
        setEmployees((prev) => prev.filter((employee) => employee.id !== id));
        setMessage(`Medewerker ${removedEmployee.email} succesvol verwijderd.`);
    };

    return (
        <div className="manage-employees" aria-label="Beheer medewerkers bedrijfsabonnement">
            <h1>Beheer Medewerkers</h1>
            <div className="form-container">
                <label htmlFor="email">Medewerker E-mailadres:</label>
                <input
                    id="email"
                    type="email"
                    value={newEmail}
                    onChange={(e) => setNewEmail(e.target.value)}
                    aria-label="Voer een zakelijk e-mailadres in"
                />
                <button onClick={handleAddEmployee} className="add-button" aria-label="Voeg medewerker toe">
                    Toevoegen
                </button>
            </div>
            {message && <p className="message" role="alert">{message}</p>}
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

export default ManageEmployees;

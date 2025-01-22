// src/pages/VehicleIssuance.jsx

import React, { useState } from 'react';
import '../styles/VehicleIssuance.css';

const VehicleIssuance = () => {
    const [transactions, setTransactions] = useState([
        {
            id: 1,
            customer: 'Jan Jansen',
            vehicle: 'Tesla Model 3',
            date: '2025-01-20',
            status: 'klaar voor uitgifte',
            remarks: '',
        },
        {
            id: 2,
            customer: 'Emma de Vries',
            vehicle: 'Volkswagen ID.4',
            date: '2025-01-21',
            status: 'klaar voor uitgifte',
            remarks: '',
        },
    ]);

    const [newRemark, setNewRemark] = useState('');

    const handleIssuance = (id) => {
        setTransactions((prev) =>
            prev.map((transaction) =>
                transaction.id === id
                    ? { ...transaction, status: 'uitgegeven', remarks: newRemark }
                    : transaction
            )
        );
        setNewRemark('');
        alert('Voertuigstatus bijgewerkt naar "uitgegeven"');
    };

    return (
        <div className="vehicle-issuance" aria-label="Registratie uitgifte voertuigen">
            <h1>Uitgifte van Voertuigen</h1>
            {transactions.map((transaction) => (
                <div key={transaction.id} className="transaction">
                    <p><strong>Klant:</strong> {transaction.customer}</p>
                    <p><strong>Voertuig:</strong> {transaction.vehicle}</p>
                    <p><strong>Datum:</strong> {transaction.date}</p>
                    <p><strong>Status:</strong> {transaction.status}</p>
                    {transaction.status === 'klaar voor uitgifte' && (
                        <div className="actions">
                            <textarea
                                value={newRemark}
                                onChange={(e) => setNewRemark(e.target.value)}
                                placeholder="Voeg opmerkingen of extra informatie toe"
                                aria-label="Voeg opmerkingen toe"
                            />
                            <button
                                onClick={() => handleIssuance(transaction.id)}
                                className="issue-button"
                                aria-label="Bevestig uitgifte van voertuig"
                            >
                                Bevestigen
                            </button>
                        </div>
                    )}
                </div>
            ))}
        </div>
    );
};

export default VehicleIssuance;

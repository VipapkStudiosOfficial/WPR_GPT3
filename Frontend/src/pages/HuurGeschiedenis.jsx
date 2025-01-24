// src/pages/HuurGeschiedenis.jsx

import React, { useState } from 'react';
import '../styles/HuurGeschiedenis.css';
import jsPDF from 'jspdf';

const RentalHistory = () => {
    const [transactions, setTransactions] = useState([
        {
            id: 1,
            vehicle: 'Tesla Model 3',
            period: '2025-01-10 - 2025-01-15',
            cost: '€500',
            type: 'Auto',
        },
        {
            id: 2,
            vehicle: 'Volkswagen ID.4',
            period: '2024-12-01 - 2024-12-05',
            cost: '€400',
            type: 'Auto',
        },
        {
            id: 3,
            vehicle: 'Ford Transit',
            period: '2024-11-20 - 2024-11-25',
            cost: '€300',
            type: 'Busje',
        },
    ]);

    const [filters, setFilters] = useState({ date: '', type: '' });

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilters((prev) => ({ ...prev, [name]: value }));
    };

    const filteredTransactions = transactions.filter((transaction) => {
        const matchesDate = filters.date ? transaction.period.includes(filters.date) : true;
        const matchesType = filters.type ? transaction.type === filters.type : true;
        return matchesDate && matchesType;
    });

    const handleDownloadInvoice = (transaction) => {
        const doc = new jsPDF();
        doc.text(`Factuur`, 10, 10);
        doc.text(`Voertuig: ${transaction.vehicle}`, 10, 20);
        doc.text(`Huurperiode: ${transaction.period}`, 10, 30);
        doc.text(`Kosten: ${transaction.cost}`, 10, 40);
        doc.save(`Factuur_${transaction.id}.pdf`);
    };

    return (
        <div className="rental-history" aria-label="Huurgeschiedenis">
            <h1>Huurgeschiedenis</h1>
            <div className="filters">
                <label>
                    Filter op datum:
                    <input
                        type="text"
                        name="date"
                        value={filters.date}
                        onChange={handleFilterChange}
                        placeholder="Bijv. 2025-01"
                        aria-label="Filter op datum"
                    />
                </label>
                <label>
                    Filter op voertuigtype:
                    <select
                        name="type"
                        value={filters.type}
                        onChange={handleFilterChange}
                        aria-label="Filter op voertuigtype"
                    >
                        <option value="">Alle</option>
                        <option value="Auto">Auto</option>
                        <option value="Busje">Camper</option>
                        <option value="Caravan">Caravan</option>
                    </select>
                </label>
            </div>
            <table className="transactions-table">
                <thead>
                    <tr>
                        <th>Voertuig</th>
                        <th>Huurperiode</th>
                        <th>Kosten</th>
                        <th>Type</th>
                        <th>Acties</th>
                    </tr>
                </thead>
                <tbody>
                    {filteredTransactions.map((transaction) => (
                        <tr key={transaction.id}>
                            <td>{transaction.vehicle}</td>
                            <td>{transaction.period}</td>
                            <td>{transaction.cost}</td>
                            <td>{transaction.type}</td>
                            <td>
                                <button
                                    onClick={() => handleDownloadInvoice(transaction)}
                                    className="download-button"
                                    aria-label="Download factuur"
                                >
                                    Download Factuur
                                </button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
};

export default RentalHistory;

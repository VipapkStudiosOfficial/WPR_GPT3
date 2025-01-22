// src/pages/OutstandingInvoices.jsx

import React, { useState } from 'react';
import '../styles/OutstandingInvoices.css';

const OutstandingInvoices = () => {
    const [filter, setFilter] = useState({ status: '', date: '' });

    const invoices = [
        {
            id: 1,
            companyName: 'Bedrijf A',
            dueDate: '2025-01-15',
            amount: 500,
            status: 'Openstaand',
        },
        {
            id: 2,
            companyName: 'Bedrijf B',
            dueDate: '2025-02-01',
            amount: 1000,
            status: 'Betaald',
        },
        {
            id: 3,
            companyName: 'Bedrijf C',
            dueDate: '2025-01-20',
            amount: 750,
            status: 'Openstaand',
        },
    ];

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilter((prev) => ({ ...prev, [name]: value }));
    };

    const filteredInvoices = invoices.filter((invoice) => {
        const matchesStatus = filter.status ? invoice.status === filter.status : true;
        const matchesDate = filter.date ? invoice.dueDate === filter.date : true;
        return matchesStatus && matchesDate;
    });

    return (
        <div className="outstanding-invoices" style={{ marginLeft: '1rem' }}>
            <h1>Overzicht Openstaande Facturen</h1>

            <div className="filters">
                <label>
                    Filter op status:
                    <select
                        name="status"
                        value={filter.status}
                        onChange={handleFilterChange}
                        aria-label="Filter op betaalstatus"
                    >
                        <option value="">Alle</option>
                        <option value="Openstaand">Openstaand</option>
                        <option value="Betaald">Betaald</option>
                    </select>
                </label>

                <label>
                    Filter op vervaldatum:
                    <input
                        type="date"
                        name="date"
                        value={filter.date}
                        onChange={handleFilterChange}
                        aria-label="Filter op factuurdatum"
                    />
                </label>
            </div>

            <div className="invoice-list">
                {filteredInvoices.length > 0 ? (
                    <table>
                        <thead>
                            <tr>
                                <th>Bedrijfsnaam</th>
                                <th>Vervaldatum</th>
                                <th>Bedrag (€)</th>
                                <th>Status</th>
                                <th>Acties</th>
                            </tr>
                        </thead>
                        <tbody>
                            {filteredInvoices.map((invoice) => (
                                <tr key={invoice.id}>
                                    <td>{invoice.companyName}</td>
                                    <td>{invoice.dueDate}</td>
                                    <td>{invoice.amount.toFixed(2)}</td>
                                    <td>{invoice.status}</td>
                                    <td>
                                        {invoice.status === 'Openstaand' && (
                                            <button className="pay-button">Betaal Nu</button>
                                        )}
                                    </td>
                                </tr>
                            ))}
                        </tbody>
                    </table>
                ) : (
                    <p>Geen facturen gevonden voor de geselecteerde filters.</p>
                )}
            </div>
        </div>
    );
};

export default OutstandingInvoices;

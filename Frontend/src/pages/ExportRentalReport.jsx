// src/pages/ExportRentalReport.jsx

import React, { useState } from 'react';
import { jsPDF } from 'jspdf';
import * as XLSX from 'xlsx';
import '../styles/ExportRentalReport.css';

const ExportRentalReport = () => {
    const [rentals, setRentals] = useState([
        {
            id: 1,
            vehicle: 'Tesla Model 3',
            period: '2025-01-01 - 2025-01-10',
            type: 'Auto',
            cost: '€500',
        },
        {
            id: 2,
            vehicle: 'Volkswagen ID.4',
            period: '2025-02-01 - 2025-02-05',
            type: 'Auto',
            cost: '€400',
        },
        {
            id: 3,
            vehicle: 'Ford Transit',
            period: '2025-01-15 - 2025-01-20',
            type: 'Busje',
            cost: '€300',
        },
    ]);

    const [filters, setFilters] = useState({ period: '', type: '', cost: '' });

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilters((prev) => ({ ...prev, [name]: value }));
    };

    const filteredRentals = rentals.filter((rental) => {
        const matchesPeriod = filters.period ? rental.period.includes(filters.period) : true;
        const matchesType = filters.type ? rental.type === filters.type : true;
        const matchesCost = filters.cost ? rental.cost.replace('€', '') <= filters.cost : true;
        return matchesPeriod && matchesType && matchesCost;
    });

    const exportToPDF = () => {
        const doc = new jsPDF();
        doc.text('Huur Overzicht', 10, 10);
        filteredRentals.forEach((rental, index) => {
            doc.text(
                `Voertuig: ${rental.vehicle}, Periode: ${rental.period}, Type: ${rental.type}, Kosten: ${rental.cost}`,
                10,
                20 + index * 10
            );
        });
        doc.save('HuurOverzicht.pdf');
    };

    const exportToExcel = () => {
        const worksheet = XLSX.utils.json_to_sheet(filteredRentals);
        const workbook = XLSX.utils.book_new();
        XLSX.utils.book_append_sheet(workbook, worksheet, 'Huur Overzicht');
        XLSX.writeFile(workbook, 'HuurOverzicht.xlsx');
    };

    return (
        <div className="export-rental-report" aria-label="Exporteren van huur overzicht">
            <h1>Exporteren van Huur Overzicht</h1>
            <div className="filters">
                <label>
                    Filter op periode:
                    <input
                        type="text"
                        name="period"
                        value={filters.period}
                        onChange={handleFilterChange}
                        placeholder="Bijv. 2025-01"
                        aria-label="Filter op periode"
                    />
                </label>
                <label>
                    Filter op type:
                    <select
                        name="type"
                        value={filters.type}
                        onChange={handleFilterChange}
                        aria-label="Filter op type"
                    >
                        <option value="">Alle</option>
                        <option value="Auto">Auto</option>
                        <option value="Busje">Busje</option>
                    </select>
                </label>
                <label>
                    Filter op kosten (maximaal):
                    <input
                        type="number"
                        name="cost"
                        value={filters.cost}
                        onChange={handleFilterChange}
                        placeholder="Bijv. 500"
                        aria-label="Filter op kosten"
                    />
                </label>
            </div>
            <div className="actions">
                <button onClick={exportToPDF} className="export-button" aria-label="Exporteer naar PDF">
                    Exporteer naar PDF
                </button>
                <button onClick={exportToExcel} className="export-button" aria-label="Exporteer naar Excel">
                    Exporteer naar Excel
                </button>
            </div>
            <table className="rental-table">
                <thead>
                    <tr>
                        <th>Voertuig</th>
                        <th>Periode</th>
                        <th>Type</th>
                        <th>Kosten</th>
                    </tr>
                </thead>
                <tbody>
                    {filteredRentals.map((rental) => (
                        <tr key={rental.id}>
                            <td>{rental.vehicle}</td>
                            <td>{rental.period}</td>
                            <td>{rental.type}</td>
                            <td>{rental.cost}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
};

export default ExportRentalReport;

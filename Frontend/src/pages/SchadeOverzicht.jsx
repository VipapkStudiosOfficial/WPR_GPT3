// src/pages/SchadeOverzicht.jsx

import React, { useState } from 'react';
import { jsPDF } from 'jspdf';
import '../styles/SchadeOverzicht.css';

const DamageCasesOverview = () => {
    const [filter, setFilter] = useState({ type: '', date: '', status: '' });
    const [damageCases, setDamageCases] = useState([
        {
            id: 1,
            date: '2025-01-10',
            renter: 'John Doe',
            vehicleType: 'SUV',
            status: 'In behandeling',
        },
        {
            id: 2,
            date: '2025-01-12',
            renter: 'Jane Smith',
            vehicleType: 'Sedan',
            status: 'Opgelost',
        },
    ]);

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilter((prev) => ({ ...prev, [name]: value }));
    };

    const handleStatusChange = (id, newStatus) => {
        setDamageCases((prev) =>
            prev.map((caseItem) =>
                caseItem.id === id ? { ...caseItem, status: newStatus } : caseItem
            )
        );
    };

    const exportToPDF = () => {
        const doc = new jsPDF();
        doc.text('Schadegevallen Overzicht', 10, 10);
        damageCases.forEach((item, index) => {
            const yOffset = 20 + index * 10;
            doc.text(
                `Datum: ${item.date}, Huurder: ${item.renter}, Voertuigtype: ${item.vehicleType}, Status: ${item.status}`,
                10,
                yOffset
            );
        });
        doc.save('Schadegevallen_Overzicht.pdf');
    };

    const filteredCases = damageCases.filter((caseItem) => {
        const matchesType = filter.type ? caseItem.vehicleType === filter.type : true;
        const matchesDate = filter.date ? caseItem.date === filter.date : true;
        const matchesStatus = filter.status ? caseItem.status === filter.status : true;
        return matchesType && matchesDate && matchesStatus;
    });

    return (
        <div className="damage-cases-overview" style={{ marginLeft: '1rem' }}>
            <h1>Schadegevallen Overzicht</h1>

            <div className="filters">
                <label>
                    Filter op voertuigtype:
                    <input
                        type="text"
                        name="type"
                        value={filter.type}
                        onChange={handleFilterChange}
                        placeholder="Bijv. SUV"
                    />
                </label>

                <label>
                    Filter op datum:
                    <input
                        type="date"
                        name="date"
                        value={filter.date}
                        onChange={handleFilterChange}
                    />
                </label>

                <label>
                    Filter op status:
                    <select
                        name="status"
                        value={filter.status}
                        onChange={handleFilterChange}
                    >
                        <option value="">Alle</option>
                        <option value="In behandeling">In behandeling</option>
                        <option value="Opgelost">Opgelost</option>
                    </select>
                </label>
            </div>

            <table>
                <thead>
                    <tr>
                        <th>Datum</th>
                        <th>Huurder</th>
                        <th>Voertuigtype</th>
                        <th>Status</th>
                        <th>Acties</th>
                    </tr>
                </thead>
                <tbody>
                    {filteredCases.map((caseItem) => (
                        <tr key={caseItem.id}>
                            <td>{caseItem.date}</td>
                            <td>{caseItem.renter}</td>
                            <td>{caseItem.vehicleType}</td>
                            <td>{caseItem.status}</td>
                            <td>
                                <select
                                    value={caseItem.status}
                                    onChange={(e) => handleStatusChange(caseItem.id, e.target.value)}
                                >
                                    <option value="In behandeling">In behandeling</option>
                                    <option value="Opgelost">Opgelost</option>
                                </select>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>

            <button onClick={exportToPDF} className="export-button">
                Exporteer naar PDF
            </button>
        </div>
    );
};

export default DamageCasesOverview;

// src/pages/VehicleOverview.jsx

import React, { useState } from 'react';
import jsPDF from 'jspdf';
import 'jspdf-autotable';
import '../styles/VehicleOverview.css';

const VehicleOverview = () => {
    const [vehicles, setVehicles] = useState([
        { id: 1, type: 'Auto', brand: 'Tesla', model: 'Model 3', renter: 'Jan Jansen', date: '2025-01-20' },
        { id: 2, type: 'Camper', brand: 'Volkswagen', model: 'California', renter: 'Emma de Vries', date: '2025-01-21' },
    ]);

    const [filters, setFilters] = useState({
        type: '',
        renter: '',
        startDate: '',
        endDate: '',
    });

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilters((prev) => ({ ...prev, [name]: value }));
    };

    const filteredVehicles = vehicles.filter((vehicle) => {
        const matchesType = filters.type ? vehicle.type === filters.type : true;
        const matchesRenter = filters.renter ? vehicle.renter.toLowerCase().includes(filters.renter.toLowerCase()) : true;
        const matchesDate =
            (!filters.startDate || new Date(vehicle.date) >= new Date(filters.startDate)) &&
            (!filters.endDate || new Date(vehicle.date) <= new Date(filters.endDate));
        return matchesType && matchesRenter && matchesDate;
    });

    const exportData = (format) => {
        if (format === 'csv') {
            const csvContent = [
                ['Type', 'Merk', 'Model', 'Huurder', 'Datum'],
                ...filteredVehicles.map((v) => [v.type, v.brand, v.model, v.renter, v.date]),
            ]
                .map((row) => row.join(','))
                .join('\n');
            const blob = new Blob([csvContent], { type: 'text/csv' });
            const url = URL.createObjectURL(blob);
            const a = document.createElement('a');
            a.href = url;
            a.download = 'vehicles.csv';
            a.click();
        } else if (format === 'pdf') {
            const doc = new jsPDF();
            doc.text('Overzicht van Verhuurde Voertuigen', 10, 10);
            doc.autoTable({
                head: [['Type', 'Merk', 'Model', 'Huurder', 'Datum']],
                body: filteredVehicles.map((v) => [v.type, v.brand, v.model, v.renter, v.date]),
                startY: 20,
            });
            doc.save('vehicles.pdf');
        }
    };

    return (
        <div className="vehicle-overview" aria-label="Overzicht van verhuurde voertuigen">
            <h1>Overzicht van Verhuurde Voertuigen</h1>
            <div className="filters">
                <label>
                    Type:
                    <select name="type" value={filters.type} onChange={handleFilterChange} aria-label="Filter op type">
                        <option value="">Alle</option>
                        <option value="Auto">Auto</option>
                        <option value="Camper">Camper</option>
                        <option value="Caravan">Caravan</option>
                    </select>
                </label>
                <label>
                    Huurder:
                    <input
                        type="text"
                        name="renter"
                        value={filters.renter}
                        onChange={handleFilterChange}
                        placeholder="Zoek op huurder"
                        aria-label="Filter op huurder"
                    />
                </label>
                <label>
                    Startdatum:
                    <input
                        type="date"
                        name="startDate"
                        value={filters.startDate}
                        onChange={handleFilterChange}
                        aria-label="Filter op startdatum"
                    />
                </label>
                <label>
                    Einddatum:
                    <input
                        type="date"
                        name="endDate"
                        value={filters.endDate}
                        onChange={handleFilterChange}
                        aria-label="Filter op einddatum"
                    />
                </label>
            </div>
            <table className="vehicles-table">
                <thead>
                    <tr>
                        <th>Type</th>
                        <th>Merk</th>
                        <th>Model</th>
                        <th>Huurder</th>
                        <th>Datum</th>
                    </tr>
                </thead>
                <tbody>
                    {filteredVehicles.map((vehicle) => (
                        <tr key={vehicle.id}>
                            <td>{vehicle.type}</td>
                            <td>{vehicle.brand}</td>
                            <td>{vehicle.model}</td>
                            <td>{vehicle.renter}</td>
                            <td>{vehicle.date}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
            <div className="export-buttons">
                <button onClick={() => exportData('csv')} aria-label="Exporteer als CSV">Exporteer als CSV</button>
                <button onClick={() => exportData('pdf')} aria-label="Exporteer als PDF">Exporteer als PDF</button>
            </div>
        </div>
    );
};

export default VehicleOverview;

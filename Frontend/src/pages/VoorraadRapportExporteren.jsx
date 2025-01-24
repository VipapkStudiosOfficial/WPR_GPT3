// src/pages/VoorraadRapportExporteren.jsx

import React, { useState } from 'react';
import { jsPDF } from 'jspdf';
import '../styles/VoorraadRapportExporteren.css';

const ExportInventoryReport = () => {
    const [vehicles, setVehicles] = useState([
        { id: 1, brand: 'Tesla', type: 'Auto', status: 'Beschikbaar', mileage: '20,000 km' },
        { id: 2, brand: 'Volkswagen', type: 'Busje', status: 'In reparatie', mileage: '50,000 km' },
        { id: 3, brand: 'Ford', type: 'Truck', status: 'Verhuurd', mileage: '70,000 km' },
    ]);

    const [filters, setFilters] = useState({ status: '', type: '' });

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilters((prev) => ({ ...prev, [name]: value }));
    };

    const filteredVehicles = vehicles.filter((vehicle) => {
        const matchesStatus = filters.status ? vehicle.status === filters.status : true;
        const matchesType = filters.type ? vehicle.type === filters.type : true;
        return matchesStatus && matchesType;
    });

    const exportToPDF = () => {
        const doc = new jsPDF();
        doc.text('Inventarisatierapport', 10, 10);
        filteredVehicles.forEach((vehicle, index) => {
            doc.text(
                `Merk: ${vehicle.brand}, Type: ${vehicle.type}, Status: ${vehicle.status}, Kilometerstand: ${vehicle.mileage}`,
                10,
                20 + index * 10
            );
        });
        doc.save('Inventarisatierapport.pdf');
    };

    return (
        <div className="export-inventory-report" aria-label="Exporteren van inventarisatierapport">
            <h1>Exporteren van Inventarisatierapport</h1>
            <div className="filters">
                <label>
                    Filter op status:
                    <select
                        name="status"
                        value={filters.status}
                        onChange={handleFilterChange}
                        aria-label="Filter op status"
                    >
                        <option value="">Alle</option>
                        <option value="Beschikbaar">Beschikbaar</option>
                        <option value="In reparatie">In reparatie</option>
                        <option value="Verhuurd">Verhuurd</option>
                    </select>
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
                        <option value="Truck">Truck</option>
                    </select>
                </label>
            </div>
            <div className="actions">
                <button onClick={exportToPDF} className="export-button" aria-label="Exporteer naar PDF">
                    Exporteer naar PDF
                </button>
            </div>
            <table className="inventory-table">
                <thead>
                    <tr>
                        <th>Merk</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>Kilometerstand</th>
                    </tr>
                </thead>
                <tbody>
                    {filteredVehicles.map((vehicle) => (
                        <tr key={vehicle.id}>
                            <td>{vehicle.brand}</td>
                            <td>{vehicle.type}</td>
                            <td>{vehicle.status}</td>
                            <td>{vehicle.mileage}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
};

export default ExportInventoryReport;

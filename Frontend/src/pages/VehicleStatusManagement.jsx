// src/pages/VehicleStatusManagement.jsx

import React, { useState } from 'react';
import '../styles/VehicleStatusManagement.css';

const VehicleStatusManagement = () => {
    const [vehicles, setVehicles] = useState([
        { id: 1, type: 'Auto', brand: 'Tesla', status: 'Beschikbaar', rentalPeriod: '' },
        { id: 2, type: 'Busje', brand: 'Volkswagen', status: 'Verhuurd', rentalPeriod: '2025-01-15 - 2025-01-20' },
        { id: 3, type: 'Camper', brand: 'Ford', status: 'In reparatie', rentalPeriod: '' },
        { id: 4, type: 'Auto', brand: 'Toyota', status: 'Geblokkeerd', rentalPeriod: '' },
    ]);

    const [filters, setFilters] = useState({ status: '', rentalPeriod: '' });
    const [newStatus, setNewStatus] = useState('');

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilters((prev) => ({ ...prev, [name]: value }));
    };

    const handleStatusUpdate = (id) => {
        if (!newStatus.trim()) {
            alert('Selecteer een nieuwe status.');
            return;
        }
        setVehicles((prev) =>
            prev.map((vehicle) =>
                vehicle.id === id ? { ...vehicle, status: newStatus } : vehicle
            )
        );
        alert('Voertuigstatus succesvol bijgewerkt.');
        setNewStatus('');
    };

    const filteredVehicles = vehicles.filter((vehicle) => {
        const matchesStatus = filters.status ? vehicle.status === filters.status : true;
        const matchesRentalPeriod = filters.rentalPeriod
            ? vehicle.rentalPeriod.includes(filters.rentalPeriod)
            : true;
        return matchesStatus && matchesRentalPeriod;
    });

    return (
        <div className="vehicle-status-management" aria-label="Voertuigstatusbeheer">
            <h1>Voertuigstatusbeheer</h1>
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
                        <option value="Verhuurd">Verhuurd</option>
                        <option value="In reparatie">In reparatie</option>
                        <option value="Geblokkeerd">Geblokkeerd</option>
                    </select>
                </label>
                <label>
                    Filter op verhuurperiode:
                    <input
                        type="text"
                        name="rentalPeriod"
                        value={filters.rentalPeriod}
                        onChange={handleFilterChange}
                        placeholder="Bijv. 2025-01-15"
                        aria-label="Filter op verhuurperiode"
                    />
                </label>
            </div>
            <table className="vehicles-table">
                <thead>
                    <tr>
                        <th>Type</th>
                        <th>Merk</th>
                        <th>Status</th>
                        <th>Verhuurperiode</th>
                        <th>Acties</th>
                    </tr>
                </thead>
                <tbody>
                    {filteredVehicles.map((vehicle) => (
                        <tr key={vehicle.id}>
                            <td>{vehicle.type}</td>
                            <td>{vehicle.brand}</td>
                            <td>{vehicle.status}</td>
                            <td>{vehicle.rentalPeriod || 'N/A'}</td>
                            <td>
                                <select
                                    value={newStatus}
                                    onChange={(e) => setNewStatus(e.target.value)}
                                    aria-label="Nieuwe status selecteren"
                                >
                                    <option value="">-- Kies status --</option>
                                    <option value="Beschikbaar">Beschikbaar</option>
                                    <option value="Verhuurd">Verhuurd</option>
                                    <option value="In reparatie">In reparatie</option>
                                    <option value="Geblokkeerd">Geblokkeerd</option>
                                </select>
                                <button
                                    onClick={() => handleStatusUpdate(vehicle.id)}
                                    className="update-button"
                                    aria-label="Update voertuigstatus"
                                >
                                    Bijwerken
                                </button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
};

export default VehicleStatusManagement;

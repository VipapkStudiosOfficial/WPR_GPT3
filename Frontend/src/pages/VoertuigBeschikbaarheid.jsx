// src/pages/VoertuigBeschikbaarheid.jsx

import React, { useState } from 'react';
import Calendar from 'react-calendar';
import 'react-calendar/dist/Calendar.css';
import '../styles/VoertuigBeschikbaarheid.css';

const VehicleAvailability = () => {
    const [selectedDate, setSelectedDate] = useState(new Date());
    const [vehicles, setVehicles] = useState([
        {
            id: 1,
            name: 'Tesla Model 3',
            type: 'Auto',
            location: 'Amsterdam',
            schedule: {
                '2025-01-10': 'Verhuurd',
                '2025-01-15': 'In onderhoud',
            },
        },
        {
            id: 2,
            name: 'Volkswagen ID.4',
            type: 'Auto',
            location: 'Rotterdam',
            schedule: {
                '2025-01-12': 'Beschikbaar',
            },
        },
    ]);

    const [filters, setFilters] = useState({ type: '', location: '' });

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilters((prev) => ({ ...prev, [name]: value }));
    };

    const filteredVehicles = vehicles.filter((vehicle) => {
        const matchesType = filters.type ? vehicle.type === filters.type : true;
        const matchesLocation = filters.location ? vehicle.location === filters.location : true;
        return matchesType && matchesLocation;
    });

    return (
        <div className="vehicle-availability" aria-label="Voertuigbeschikbaarheid">
            <h1>Planningsoverzicht Voertuigen</h1>

            <div className="filters">
                <label>
                    Filter op type:
                    <select
                        name="type"
                        value={filters.type}
                        onChange={handleFilterChange}
                        aria-label="Filter op type voertuig"
                    >
                        <option value="">Alle</option>
                        <option value="Auto">Auto</option>
                        <option value="Busje">Busje</option>
                    </select>
                </label>

                <label>
                    Filter op locatie:
                    <input
                        type="text"
                        name="location"
                        value={filters.location}
                        onChange={handleFilterChange}
                        placeholder="Bijv. Amsterdam"
                        aria-label="Filter op locatie"
                    />
                </label>
            </div>

            <Calendar
                value={selectedDate}
                onChange={setSelectedDate}
                aria-label="Kalenderoverzicht"
            />

            <div className="vehicle-schedule">
                <h2>Beschikbaarheid op {selectedDate.toLocaleDateString()}</h2>
                <ul>
                    {filteredVehicles.map((vehicle) => (
                        <li key={vehicle.id}>
                            {vehicle.name} ({vehicle.type}) - Locatie: {vehicle.location} - Status: {
                                vehicle.schedule[selectedDate.toISOString().split('T')[0]] || 'Geen planning'
                            }
                        </li>
                    ))}
                </ul>
            </div>
        </div>
    );
};

export default VehicleAvailability;

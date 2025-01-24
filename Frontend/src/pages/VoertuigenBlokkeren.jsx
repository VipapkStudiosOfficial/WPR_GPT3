// src/pages/VoertuigenBlokkeren.jsx

import React, { useState } from 'react';
import '../styles/VoertuigenBlokkeren.css';

const BlockVehicles = () => {
    const [vehicles, setVehicles] = useState([
        { id: 1, brand: 'Tesla', model: 'Model 3', status: 'Beschikbaar', notes: '' },
        { id: 2, brand: 'Volkswagen', model: 'ID.4', status: 'Beschikbaar', notes: '' },
        { id: 3, brand: 'Ford', model: 'Transit', status: 'Beschikbaar', notes: '' },
    ]);

    const [blockReason, setBlockReason] = useState('');
    const [notes, setNotes] = useState('');

    const handleBlockVehicle = (id) => {
        if (!blockReason.trim()) {
            alert('Voer een reden in voor blokkering.');
            return;
        }
        setVehicles((prev) =>
            prev.map((vehicle) =>
                vehicle.id === id
                    ? { ...vehicle, status: 'Geblokkeerd', notes: `${blockReason}${notes ? ` - ${notes}` : ''}` }
                    : vehicle
            )
        );
        setBlockReason('');
        setNotes('');
        alert('Voertuig succesvol geblokkeerd.');
    };

    const handleUnblockVehicle = (id) => {
        setVehicles((prev) =>
            prev.map((vehicle) =>
                vehicle.id === id ? { ...vehicle, status: 'Beschikbaar', notes: '' } : vehicle
            )
        );
        alert('Voertuig succesvol gedeblokkeerd.');
    };

    return (
        <div className="block-vehicles" aria-label="Voertuigen blokkeren">
            <h1>Voertuigen Blokkeren</h1>
            <table className="vehicles-table">
                <thead>
                    <tr>
                        <th>Merk</th>
                        <th>Model</th>
                        <th>Status</th>
                        <th>Notities</th>
                        <th>Acties</th>
                    </tr>
                </thead>
                <tbody>
                    {vehicles.map((vehicle) => (
                        <tr key={vehicle.id}>
                            <td>{vehicle.brand}</td>
                            <td>{vehicle.model}</td>
                            <td>{vehicle.status}</td>
                            <td>{vehicle.notes || 'N/A'}</td>
                            <td>
                                {vehicle.status === 'Beschikbaar' ? (
                                    <div className="actions">
                                        <textarea
                                            placeholder="Reden voor blokkering"
                                            value={blockReason}
                                            onChange={(e) => setBlockReason(e.target.value)}
                                            aria-label="Reden voor blokkering"
                                        />
                                        <textarea
                                            placeholder="Notities (optioneel)"
                                            value={notes}
                                            onChange={(e) => setNotes(e.target.value)}
                                            aria-label="Notities"
                                        />
                                        <button
                                            onClick={() => handleBlockVehicle(vehicle.id)}
                                            className="block-button"
                                            aria-label="Blokkeer voertuig"
                                        >
                                            Blokkeren
                                        </button>
                                    </div>
                                ) : (
                                    <button
                                        onClick={() => handleUnblockVehicle(vehicle.id)}
                                        className="unblock-button"
                                        aria-label="Deblokkeer voertuig"
                                    >
                                        Deblokkeren
                                    </button>
                                )}
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
};

export default BlockVehicles;

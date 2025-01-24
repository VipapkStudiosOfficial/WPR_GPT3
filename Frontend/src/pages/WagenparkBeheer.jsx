// src/pages/WagenparkBeheer.jsx

import React, { useState } from 'react';
import '../styles/WagenparkBeheer.css';

const FleetManagement = () => {
    const [vehicles, setVehicles] = useState([
        { id: 1, brand: 'Tesla', type: 'Model 3', color: 'Rood', year: 2020, plate: 'XX-123-YY', remarks: 'In goede staat' },
        { id: 2, brand: 'Volkswagen', type: 'ID.4', color: 'Blauw', year: 2021, plate: 'AA-456-BB', remarks: 'Kleine kras op de bumper' },
    ]);
    const [newVehicle, setNewVehicle] = useState({ brand: '', type: '', color: '', year: '', plate: '', remarks: '' });
    const [message, setMessage] = useState('');

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setNewVehicle((prev) => ({ ...prev, [name]: value }));
    };

    const handleAddVehicle = () => {
        if (!newVehicle.brand || !newVehicle.type || !newVehicle.color || !newVehicle.year || !newVehicle.plate) {
            setMessage('Alle velden zijn verplicht.');
            return;
        }
        setVehicles((prev) => [...prev, { id: Date.now(), ...newVehicle }]);
        setNewVehicle({ brand: '', type: '', color: '', year: '', plate: '', remarks: '' });
        setMessage('Voertuig succesvol toegevoegd.');
    };

    const handleDeleteVehicle = (id) => {
        setVehicles((prev) => prev.filter((vehicle) => vehicle.id !== id));
        setMessage('Voertuig succesvol verwijderd.');
    };

    const handleUpdateVehicle = (id, field, value) => {
        setVehicles((prev) =>
            prev.map((vehicle) =>
                vehicle.id === id ? { ...vehicle, [field]: value } : vehicle
            )
        );
        setMessage('Voertuiggegevens succesvol bijgewerkt.');
    };

    return (
        <div className="fleet-management" aria-label="Wagenparkbeheer">
            <h1>Wagenparkbeheer</h1>
            <div className="form-container">
                <h2>Voertuig Toevoegen</h2>
                <input
                    type="text"
                    name="brand"
                    value={newVehicle.brand}
                    onChange={handleInputChange}
                    placeholder="Merk"
                    aria-label="Voer merk in"
                />
                <input
                    type="text"
                    name="type"
                    value={newVehicle.type}
                    onChange={handleInputChange}
                    placeholder="Type"
                    aria-label="Voer type in"
                />
                <input
                    type="text"
                    name="color"
                    value={newVehicle.color}
                    onChange={handleInputChange}
                    placeholder="Kleur"
                    aria-label="Voer kleur in"
                />
                <input
                    type="number"
                    name="year"
                    value={newVehicle.year}
                    onChange={handleInputChange}
                    placeholder="Bouwjaar"
                    aria-label="Voer bouwjaar in"
                />
                <input
                    type="text"
                    name="plate"
                    value={newVehicle.plate}
                    onChange={handleInputChange}
                    placeholder="Kenteken"
                    aria-label="Voer kenteken in"
                />
                <textarea
                    name="remarks"
                    value={newVehicle.remarks}
                    onChange={handleInputChange}
                    placeholder="Opmerkingen"
                    aria-label="Voer opmerkingen in"
                />
                <button onClick={handleAddVehicle} className="add-button" aria-label="Voeg voertuig toe">
                    Toevoegen
                </button>
            </div>
            {message && <p className="message" role="alert">{message}</p>}
            <div className="vehicle-list">
                <h2>Wagenpark</h2>
                <ul>
                    {vehicles.map((vehicle) => (
                        <li key={vehicle.id} className="vehicle-item">
                            <p><strong>Merk:</strong> {vehicle.brand}</p>
                            <p><strong>Type:</strong> {vehicle.type}</p>
                            <p><strong>Kleur:</strong> {vehicle.color}</p>
                            <p><strong>Bouwjaar:</strong> {vehicle.year}</p>
                            <p><strong>Kenteken:</strong> {vehicle.plate}</p>
                            <p><strong>Opmerkingen:</strong> {vehicle.remarks}</p>
                            <button
                                onClick={() => handleDeleteVehicle(vehicle.id)}
                                className="delete-button"
                                aria-label="Verwijder voertuig"
                            >
                                Verwijderen
                            </button>
                        </li>
                    ))}
                </ul>
            </div>
        </div>
    );
};

export default FleetManagement;

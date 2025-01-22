// src/pages/SearchCustomerInfo.jsx

import React, { useState } from 'react';
import '../styles/SearchCustomerInfo.css';

const SearchCustomerInfo = () => {
    const [searchQuery, setSearchQuery] = useState('');
    const [searchResults, setSearchResults] = useState([]);

    const customers = [
        {
            id: 1,
            name: 'Jan Jansen',
            licensePlate: 'AB-123-CD',
            reservationNumber: 'RES001',
            vehicleStatus: 'Verhuurd',
            rentalPeriod: '2025-01-10 - 2025-01-15',
        },
        {
            id: 2,
            name: 'Marie Verhoeven',
            licensePlate: 'EF-456-GH',
            reservationNumber: 'RES002',
            vehicleStatus: 'Beschikbaar',
            rentalPeriod: 'Geen',
        },
    ];

    const handleSearch = (e) => {
        const query = e.target.value.toLowerCase();
        setSearchQuery(query);

        const results = customers.filter(
            (customer) =>
                customer.name.toLowerCase().includes(query) ||
                customer.licensePlate.toLowerCase().includes(query) ||
                customer.reservationNumber.toLowerCase().includes(query)
        );

        setSearchResults(results);
    };

    return (
        <div className="search-customer-info" style={{ marginLeft: '1rem' }}>
            <h1>Klantinformatie Zoeken</h1>
            <input
                type="text"
                value={searchQuery}
                onChange={handleSearch}
                placeholder="Zoek op naam, kenteken of reserveringsnummer"
                aria-label="Zoek klantinformatie"
                className="search-bar"
            />

            <div className="search-results" aria-live="polite">
                {searchResults.length > 0 ? (
                    <ul>
                        {searchResults.map((customer) => (
                            <li key={customer.id}>
                                <p><strong>Naam:</strong> {customer.name}</p>
                                <p><strong>Kenteken:</strong> {customer.licensePlate}</p>
                                <p><strong>Reserveringsnummer:</strong> {customer.reservationNumber}</p>
                                <p><strong>Status:</strong> {customer.vehicleStatus}</p>
                                <p><strong>Huurperiode:</strong> {customer.rentalPeriod}</p>
                            </li>
                        ))}
                    </ul>
                ) : (
                    searchQuery && <p>Geen resultaten gevonden voor "{searchQuery}".</p>
                )}
            </div>
        </div>
    );
};

export default SearchCustomerInfo;

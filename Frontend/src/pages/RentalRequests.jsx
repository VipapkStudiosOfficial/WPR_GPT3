// src/pages/RentalRequests.jsx

import React, { useState } from 'react';
import '../styles/RentalRequests.css';

const RentalRequests = () => {
    const [requests, setRequests] = useState([
        { id: 1, name: 'Jan Jansen', car: 'Tesla Model 3', date: '2025-01-20', status: 'pending' },
        { id: 2, name: 'Emma de Vries', car: 'Volkswagen ID.4', date: '2025-01-21', status: 'pending' },
    ]);
    const [reason, setReason] = useState('');

    const handleApprove = (id) => {
        setRequests((prev) =>
            prev.map((req) => (req.id === id ? { ...req, status: 'approved' } : req))
        );
        alert('Aanvraag goedgekeurd!');
    };

    const handleReject = (id) => {
        if (!reason.trim()) {
            alert('Voer een reden in voor afwijzing.');
            return;
        }
        setRequests((prev) =>
            prev.map((req) => (req.id === id ? { ...req, status: 'rejected', reason } : req))
        );
        setReason('');
        alert('Aanvraag afgewezen!');
    };

    return (
        <div className="rental-requests" aria-label="Beheer van verhuuraanvragen">
            <h1>Verhuuraanvragen</h1>
            <div className="requests-list">
                {requests.map((request) => (
                    <div key={request.id} className={`request ${request.status}`}>
                        <p><strong>Naam:</strong> {request.name}</p>
                        <p><strong>Voertuig:</strong> {request.car}</p>
                        <p><strong>Datum:</strong> {request.date}</p>
                        <p><strong>Status:</strong> {request.status}</p>
                        {request.status === 'rejected' && (
                            <p><strong>Reden afwijzing:</strong> {request.reason}</p>
                        )}
                        {request.status === 'pending' && (
                            <div className="actions">
                                <button onClick={() => handleApprove(request.id)} className="approve-button" aria-label="Goedkeuren">
                                    Goedkeuren
                                </button>
                                <input
                                    type="text"
                                    placeholder="Reden voor afwijzing"
                                    value={reason}
                                    onChange={(e) => setReason(e.target.value)}
                                    aria-label="Reden voor afwijzing"
                                />
                                <button onClick={() => handleReject(request.id)} className="reject-button" aria-label="Afwijzen">
                                    Afwijzen
                                </button>
                            </div>
                        )}
                    </div>
                ))}
            </div>
        </div>
    );
};

export default RentalRequests;
// src/pages/ApproveRejectSubscriptions.jsx

import React, { useState } from 'react';
import '../styles/ApproveRejectSubscriptions.css';

const ApproveRejectSubscriptions = () => {
    const [subscriptions, setSubscriptions] = useState([
        {
            id: 1,
            companyName: 'Tech Solutions BV',
            address: 'Hoofdstraat 123, Amsterdam',
            kvkNumber: '12345678',
            subscriptionType: 'Prepaid',
            status: 'pending',
        },
        {
            id: 2,
            companyName: 'Green Energy Co.',
            address: 'Groenstraat 45, Utrecht',
            kvkNumber: '87654321',
            subscriptionType: 'Pay-As-You-Go',
            status: 'pending',
        },
    ]);

    const [rejectionReason, setRejectionReason] = useState('');

    const handleApprove = (id) => {
        setSubscriptions((prev) =>
            prev.map((sub) =>
                sub.id === id ? { ...sub, status: 'approved' } : sub
            )
        );
        alert('Het bedrijfsabonnement is goedgekeurd.');
    };

    const handleReject = (id) => {
        if (!rejectionReason.trim()) {
            alert('Voer een reden voor afwijzing in.');
            return;
        }
        setSubscriptions((prev) =>
            prev.map((sub) =>
                sub.id === id ? { ...sub, status: 'rejected', rejectionReason } : sub
            )
        );
        alert(`Het bedrijfsabonnement is afgewezen met de reden: ${rejectionReason}`);
        setRejectionReason('');
    };

    return (
        <div className="approve-reject-subscriptions" aria-label="Goedkeuren of afwijzen bedrijfsabonnementen">
            <h1>Bedrijfsabonnementen Beheren</h1>
            {subscriptions.map((subscription) => (
                <div key={subscription.id} className="subscription-card">
                    <p><strong>Bedrijfsnaam:</strong> {subscription.companyName}</p>
                    <p><strong>Adres:</strong> {subscription.address}</p>
                    <p><strong>KVK-nummer:</strong> {subscription.kvkNumber}</p>
                    <p><strong>Abonnementstype:</strong> {subscription.subscriptionType}</p>
                    <p><strong>Status:</strong> {subscription.status}</p>

                    {subscription.status === 'pending' && (
                        <div className="actions">
                            <textarea
                                placeholder="Reden voor afwijzing"
                                value={rejectionReason}
                                onChange={(e) => setRejectionReason(e.target.value)}
                                aria-label="Reden voor afwijzing"
                            />
                            <button
                                onClick={() => handleApprove(subscription.id)}
                                className="approve-button"
                                aria-label="Goedkeuren bedrijfsabonnement"
                            >
                                Goedkeuren
                            </button>
                            <button
                                onClick={() => handleReject(subscription.id)}
                                className="reject-button"
                                aria-label="Afwijzen bedrijfsabonnement"
                            >
                                Afwijzen
                            </button>
                        </div>
                    )}

                    {subscription.status === 'rejected' && (
                        <p><strong>Reden voor afwijzing:</strong> {subscription.rejectionReason}</p>
                    )}
                </div>
            ))}
        </div>
    );
};

export default ApproveRejectSubscriptions;

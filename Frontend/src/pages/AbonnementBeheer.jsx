// src/pages/AbonnementBeheer.jsx

import React, { useState } from 'react';
import '../styles/AbonnementBeheer.css';

const SubscriptionManagement = () => {
    const [currentPlan, setCurrentPlan] = useState('Pay-As-You-Go');
    const [newPlan, setNewPlan] = useState('');
    const [costDetails, setCostDetails] = useState(null);
    const [confirmationMessage, setConfirmationMessage] = useState('');

    const availablePlans = [
        { name: 'Pay-As-You-Go', cost: '€10 per gebruik' },
        { name: 'Prepaid', cost: '€500 per maand' },
        { name: 'Enterprise', cost: 'Prijs op aanvraag' },
    ];

    const handlePlanChange = (e) => {
        const selectedPlan = e.target.value;
        setNewPlan(selectedPlan);
        const selectedDetails = availablePlans.find((plan) => plan.name === selectedPlan);
        setCostDetails(selectedDetails);
    };

    const handleSubmit = () => {
        if (!newPlan) {
            setConfirmationMessage('Selecteer een abonnementstype.');
            return;
        }
        setCurrentPlan(newPlan);
        setConfirmationMessage(`Uw abonnement is gewijzigd naar '${newPlan}'. De wijzigingen worden actief bij de volgende abonnementsperiode.`);
        setNewPlan('');
        setCostDetails(null);
    };

    return (
        <div className="subscription-management" aria-label="Beheer abonnementen">
            <h1>Abonnement beheren</h1>
            <div className="current-plan">
                <h2>Huidig abonnement</h2>
                <p><strong>Abonnementstype:</strong> {currentPlan}</p>
            </div>
            <div className="change-plan">
                <h2>Wijzig abonnement</h2>
                <label htmlFor="plan-select">Selecteer een nieuw abonnementstype:</label>
                <select
                    id="plan-select"
                    value={newPlan}
                    onChange={handlePlanChange}
                    aria-label="Selecteer abonnementstype"
                >
                    <option value="">-- Kies een optie --</option>
                    {availablePlans.map((plan) => (
                        <option key={plan.name} value={plan.name}>{plan.name}</option>
                    ))}
                </select>
                {costDetails && (
                    <p className="cost-details">
                        <strong>Kosten:</strong> {costDetails.cost}
                    </p>
                )}
                <button onClick={handleSubmit} className="confirm-button" aria-label="Bevestig abonnementswijziging">
                    Bevestigen
                </button>
            </div>
            {confirmationMessage && <p className="confirmation-message" role="alert">{confirmationMessage}</p>}
        </div>
    );
};

export default SubscriptionManagement;

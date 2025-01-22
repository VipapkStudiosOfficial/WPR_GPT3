// src/pages/CancelReservation.jsx

import React, { useState } from 'react';
import '../styles/CancelReservation.css';

const CancelReservation = () => {
    const [reservations, setReservations] = useState([
        {
            id: 1,
            vehicle: 'Tesla Model 3',
            period: '2025-01-10 - 2025-01-15',
            cost: '€500',
            cancellationFee: '€50',
        },
        {
            id: 2,
            vehicle: 'Volkswagen ID.4',
            period: '2025-02-01 - 2025-02-05',
            cost: '€400',
            cancellationFee: '€40',
        },
    ]);

    const [confirmation, setConfirmation] = useState(null);

    const handleCancel = (id) => {
        setConfirmation(id);
    };

    const confirmCancel = () => {
        setReservations((prev) => prev.filter((reservation) => reservation.id !== confirmation));
        alert('Reservering geannuleerd. Een bevestigingsmail is verzonden.');
        setConfirmation(null);
    };

    const cancelConfirmDialog = () => {
        setConfirmation(null);
    };

    return (
        <div className="cancel-reservation" aria-label="Reservering annuleren" style={{ marginLeft: '1rem' }}>
            <h1>Reservering Annuleren</h1>
            <table className="reservation-table">
                <thead>
                    <tr>
                        <th>Voertuig</th>
                        <th>Huurperiode</th>
                        <th>Kosten</th>
                        <th>Annuleringskosten</th>
                        <th>Acties</th>
                    </tr>
                </thead>
                <tbody>
                    {reservations.map((reservation) => (
                        <tr key={reservation.id}>
                            <td>{reservation.vehicle}</td>
                            <td>{reservation.period}</td>
                            <td>{reservation.cost}</td>
                            <td>{reservation.cancellationFee}</td>
                            <td>
                                <button
                                    onClick={() => handleCancel(reservation.id)}
                                    className="cancel-button"
                                    aria-label="Annuleer reservering"
                                >
                                    Annuleren
                                </button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>

            {confirmation && (
                <div className="confirmation-dialog" aria-label="Bevestigingsdialoog">
                    <p>Weet u zeker dat u deze reservering wilt annuleren?</p>
                    <button onClick={confirmCancel} className="confirm-button" aria-label="Bevestig annulering">
                        Bevestigen
                    </button>
                    <button
                        onClick={cancelConfirmDialog}
                        className="cancel-dialog-button"
                        aria-label="Annuleren bevestigingsdialoog"
                    >
                        Annuleren
                    </button>
                </div>
            )}
        </div>
    );
};

export default CancelReservation;

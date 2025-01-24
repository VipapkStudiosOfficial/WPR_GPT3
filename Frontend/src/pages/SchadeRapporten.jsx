// src/pages/SchadeRapporten.jsx

import React, { useState } from 'react';
import '../styles/SchadeRapporten.css';

const DamageReports = () => {
    const [damageReports, setDamageReports] = useState([
        {
            id: 1,
            vehicle: 'Tesla Model 3',
            date: '2025-01-15',
            description: 'Deuk in linkerdeur',
            photos: ['photo1.jpg', 'photo2.jpg'],
            status: 'gerepareerd',
            comments: ['Onderdeel vervangen door garage.'],
        },
        {
            id: 2,
            vehicle: 'Volkswagen ID.4',
            date: '2025-01-18',
            description: 'Kras op achterbumper',
            photos: ['photo3.jpg'],
            status: 'in reparatie',
            comments: [],
        },
    ]);

    const [newComment, setNewComment] = useState('');

    const handleStatusChange = (id, status) => {
        setDamageReports((prevReports) =>
            prevReports.map((report) => (report.id === id ? { ...report, status } : report))
        );
    };

    const handleAddComment = (id) => {
        if (!newComment.trim()) return;
        setDamageReports((prevReports) =>
            prevReports.map((report) =>
                report.id === id
                    ? { ...report, comments: [...report.comments, newComment] }
                    : report
            )
        );
        setNewComment('');
    };

    return (
        <div className="damage-reports" aria-label="Schademeldingen overzicht">
            <h1>Schademeldingen</h1>
            {damageReports.map((report) => (
                <div key={report.id} className="damage-report">
                    <h2>{report.vehicle}</h2>
                    <p><strong>Datum:</strong> {report.date}</p>
                    <p><strong>Beschrijving:</strong> {report.description}</p>
                    <div className="photos">
                        {report.photos.map((photo, index) => (
                            <img key={index} src={photo} alt={`Schadefoto ${index + 1}`} className="damage-photo" />
                        ))}
                    </div>
                    <p><strong>Status:</strong> {report.status}</p>
                    <div className="status-buttons">
                        <button
                            onClick={() => handleStatusChange(report.id, 'in reparatie')}
                            aria-label="Markeer als in reparatie"
                        >
                            In Reparatie
                        </button>
                        <button
                            onClick={() => handleStatusChange(report.id, 'gerepareerd')}
                            aria-label="Markeer als gerepareerd"
                        >
                            Gerepareerd
                        </button>
                    </div>
                    <div className="comments">
                        <h3>Opmerkingen</h3>
                        <ul>
                            {report.comments.map((comment, index) => (
                                <li key={index}>{comment}</li>
                            ))}
                        </ul>
                        <textarea
                            value={newComment}
                            onChange={(e) => setNewComment(e.target.value)}
                            placeholder="Voeg een opmerking toe"
                            aria-label="Voeg een opmerking toe"
                        />
                        <button onClick={() => handleAddComment(report.id)} aria-label="Opmerking toevoegen">
                            Toevoegen
                        </button>
                    </div>
                </div>
            ))}
        </div>
    );
};

export default DamageReports;

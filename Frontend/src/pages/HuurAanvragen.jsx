import React, { useEffect, useState } from "react";
import "../styles/HuurAanvragen.css";

const HuurAanvragen = () => {
    const [aanvragen, setAanvragen] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);
    const [rejectionReasons, setRejectionReasons] = useState({});

    useEffect(() => {
        const fetchAanvragen = async () => {
            try {
                const response = await fetch("/api/huur-aanvragen");
                if (!response.ok) {
                    throw new Error("Failed to fetch rental requests.");
                }
                const data = await response.json();
                setAanvragen(data);
            } catch (err) {
                setError(err.message);
            } finally {
                setLoading(false);
            }
        };

        fetchAanvragen();
    }, []);

    const approveRequest = (id) => {
        setAanvragen((prev) =>
            prev.map((request) =>
                request.id === id ? { ...request, status: "approved" } : request
            )
        );
    };

    const rejectRequest = (id) => {
        const reason = rejectionReasons[id];
        if (!reason) {
            alert("Voer een reden voor afwijzing in.");
            return;
        }

        setAanvragen((prev) =>
            prev.map((request) =>
                request.id === id
                    ? { ...request, status: "rejected", rejectionReason: reason }
                    : request
            )
        );
    };

    const handleReasonChange = (id, value) => {
        setRejectionReasons((prev) => ({ ...prev, [id]: value }));
    };

    if (loading) return <p>Loading rental requests...</p>;
    if (error) return <p>Error: {error}</p>;

    return (
        <div className="rental-requests">
            <h1 className="title">Huur Aanvragen</h1>
            {aanvragen.length === 0 ? (
                <p className="no-requests">Geen huur aanvragen beschikbaar.</p>
            ) : (
                <ul className="request-list">
                    {aanvragen.map((request) => (
                        <li
                            key={request.id}
                            className={`request-item request ${request.status}`}
                        >
                            <div className="request-details">
                                <p><strong>Naam:</strong> {request.naam}</p>
                                <p><strong>Voertuig:</strong> {request.voertuig || "Geen voertuig gekoppeld"}</p>
                                <p><strong>Datum:</strong> {request.aanvraagDatum}</p>
                                <p><strong>Status:</strong> {request.status}</p>
                                {request.status === "rejected" && request.rejectionReason && (
                                    <p><strong>Reden voor afwijzing:</strong> {request.rejectionReason}</p>
                                )}
                            </div>
                            <div className="request-actions">
                                <button
                                    className="approve-button"
                                    onClick={() => approveRequest(request.id)}
                                >
                                    Goedkeuren
                                </button>
                                <input
                                    type="text"
                                    placeholder="Reden voor afwijzing"
                                    value={rejectionReasons[request.id] || ""}
                                    onChange={(e) => handleReasonChange(request.id, e.target.value)}
                                    className="rejection-input"
                                />
                                <button
                                    className="reject-button"
                                    onClick={() => rejectRequest(request.id)}
                                >
                                    Afwijzen
                                </button>
                            </div>
                        </li>
                    ))}
                </ul>
            )}
        </div>
    );
};

export default HuurAanvragen;

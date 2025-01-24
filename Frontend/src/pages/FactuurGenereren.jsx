// src/pages/FactuurGenereren.jsx

import React, { useState } from 'react';
import { jsPDF } from 'jspdf';
import '../styles/FactuurGenereren.css';

const GenerateInvoice = () => {
    const [invoiceDetails, setInvoiceDetails] = useState({
        companyName: '',
        rentalPeriod: '',
        extraCosts: 0,
        totalAmount: 0,
    });

    const handleChange = (e) => {
        const { name, value } = e.target;
        setInvoiceDetails((prev) => ({ ...prev, [name]: value }));
    };

    const calculateTotal = () => {
        const baseAmount = 500; // Example base amount
        const total = baseAmount + parseFloat(invoiceDetails.extraCosts || 0);
        setInvoiceDetails((prev) => ({ ...prev, totalAmount: total }));
    };

    const exportToPDF = () => {
        const doc = new jsPDF();
        doc.text('Factuur', 10, 10);
        doc.text(`Bedrijfsnaam: ${invoiceDetails.companyName}`, 10, 20);
        doc.text(`Huurperiode: ${invoiceDetails.rentalPeriod}`, 10, 30);
        doc.text(`Extra kosten: €${invoiceDetails.extraCosts}`, 10, 40);
        doc.text(`Totaalbedrag: €${invoiceDetails.totalAmount}`, 10, 50);
        doc.text('Betalingsinstructies: Maak het bedrag over naar rekening NL00BANK0123456789.', 10, 60);
        doc.save(`Factuur_${invoiceDetails.companyName}.pdf`);
    };

    return (
        <div className="generate-invoice" style={{ marginLeft: '1rem' }}>
            <h1>Factuur Genereren</h1>
            <form onSubmit={(e) => e.preventDefault()}>
                <label>
                    Bedrijfsnaam:
                    <input
                        type="text"
                        name="companyName"
                        value={invoiceDetails.companyName}
                        onChange={handleChange}
                        placeholder="Voer bedrijfsnaam in"
                        required
                    />
                </label>

                <label>
                    Huurperiode:
                    <input
                        type="text"
                        name="rentalPeriod"
                        value={invoiceDetails.rentalPeriod}
                        onChange={handleChange}
                        placeholder="Bijv. 2025-01-01 tot 2025-01-31"
                        required
                    />
                </label>

                <label>
                    Extra kosten:
                    <input
                        type="number"
                        name="extraCosts"
                        value={invoiceDetails.extraCosts}
                        onChange={handleChange}
                        placeholder="Bijv. 50"
                        min="0"
                    />
                </label>

                <button type="button" onClick={calculateTotal} className="calculate-button">
                    Bereken Totaal
                </button>
            </form>

            {invoiceDetails.totalAmount > 0 && (
                <div className="invoice-summary">
                    <h2>Factuuroverzicht</h2>
                    <p><strong>Bedrijfsnaam:</strong> {invoiceDetails.companyName}</p>
                    <p><strong>Huurperiode:</strong> {invoiceDetails.rentalPeriod}</p>
                    <p><strong>Extra kosten:</strong> €{invoiceDetails.extraCosts}</p>
                    <p><strong>Totaalbedrag:</strong> €{invoiceDetails.totalAmount}</p>
                </div>
            )}

            <button onClick={exportToPDF} className="export-button" disabled={!invoiceDetails.totalAmount}>
                Exporteer naar PDF
            </button>
        </div>
    );
};

export default GenerateInvoice;

// src/pages/MaandgebruikRapport.jsx

import React from 'react';
import { jsPDF } from 'jspdf';
import '../styles/MaandgebruikRapport.css';

const MonthlyUsageReport = () => {
    const reportData = [
        {
            vehicle: 'Toyota Corolla',
            kilometers: 1200,
            rentalPeriod: '2025-01-01 - 2025-01-15',
            extraCosts: 50,
            damages: 'Geen',
        },
        {
            vehicle: 'Ford Fiesta',
            kilometers: 800,
            rentalPeriod: '2025-01-05 - 2025-01-10',
            extraCosts: 30,
            damages: 'Kras op achterdeur',
        },
    ];

    const exportToPDF = () => {
        const doc = new jsPDF();
        doc.text('Maandrapport Voertuiggebruik', 10, 10);

        reportData.forEach((item, index) => {
            const yOffset = 20 + index * 10;
            doc.text(
                `Voertuig: ${item.vehicle}, Kilometers: ${item.kilometers}, Periode: ${item.rentalPeriod}, Extra kosten: €${item.extraCosts}, Schade: ${item.damages}`,
                10,
                yOffset
            );
        });

        doc.save('Maandrapport_Voertuiggebruik.pdf');
    };

    return (
        <div className="monthly-usage-report" style={{ marginLeft: '1rem' }}>
            <h1>Maandrapport Voertuiggebruik</h1>

            <table>
                <thead>
                    <tr>
                        <th>Voertuig</th>
                        <th>Gereden Kilometers</th>
                        <th>Huurperiode</th>
                        <th>Extra Kosten (€)</th>
                        <th>Schademeldingen</th>
                    </tr>
                </thead>
                <tbody>
                    {reportData.map((item, index) => (
                        <tr key={index}>
                            <td>{item.vehicle}</td>
                            <td>{item.kilometers}</td>
                            <td>{item.rentalPeriod}</td>
                            <td>{item.extraCosts}</td>
                            <td>{item.damages}</td>
                        </tr>
                    ))}
                </tbody>
            </table>

            <button onClick={exportToPDF} className="export-button">
                Exporteer naar PDF
            </button>
        </div>
    );
};

export default MonthlyUsageReport;

// components/DashboardLayout.jsx
import React from "react";
import { Link, Outlet } from 'react-router-dom';
import "../styles/DashboardLayout.css";

const DashboardLayout = () => {
    return (
        <div className="dashboard">
            <header className="header">CarAndAll Dashboard</header>
            <div className="content">
                <aside className="sidebar">
                    <nav>
                        <ul style={{ padding: '0', margin: '0' }}>
                            <li style={{ marginBottom: '4rem' }}>
                                <strong className="category-title" style={{ fontSize: '1.2rem', display: 'block', marginBottom: '1rem' }}>Account</strong>
                                <ul className="category-links" style={{ marginLeft: '1.2rem', listStyleType: 'circle', paddingLeft: '1rem' }}>
                                    <li><Link to="/account-settings" aria-label="Accountinstellingen pagina">Accountinstellingen</Link></li>
                                    <li><Link to="/business-account-settings" aria-label="Bedrijfsaccountinstellingen pagina">Bedrijfsaccountinstellingen</Link></li>
                                </ul>
                            </li>

                            <li style={{ marginBottom: '4rem' }}>
                                <strong className="category-title" style={{ fontSize: '1.2rem', display: 'block', marginBottom: '1rem' }}>Abonnementen</strong>
                                <ul className="category-links" style={{ marginLeft: '1.2rem', listStyleType: 'circle', paddingLeft: '1rem' }}>
                                    <li><Link to="/subscription-management" aria-label="Abonnement Beheren pagina">Abonnement Beheren</Link></li>
                                    <li><Link to="/approve-reject-subscriptions" aria-label="Goedkeuren/Afwijzen Abonnementen pagina">Goedkeuren/Afwijzen Abonnementen</Link></li>
                                    <li><Link to="/outstanding-invoices" aria-label="Openstaande Facturen pagina">Openstaande Facturen</Link></li>
                                </ul>
                            </li>

                            <li style={{ marginBottom: '4rem' }}>
                                <strong className="category-title" style={{ fontSize: '1.2rem', display: 'block', marginBottom: '1rem' }}>Wagenparkbeheerder</strong>
                                <ul className="category-links" style={{ marginLeft: '1.2rem', listStyleType: 'circle', paddingLeft: '1rem' }}>
                                    <li><Link to="/fleet-manager" aria-label="Zakelijke Huurders Beheren pagina">Zakelijke Huurders Beheren</Link></li>
                                    <li><Link to="/vehicle-status-management" aria-label="Voertuigstatus Beheren pagina">Voertuigstatus Beheren</Link></li>
                                    <li><Link to="/block-vehicles" aria-label="Voertuigen Blokkeren pagina">Voertuigen Blokkeren</Link></li>
                                    <li><Link to="/export-inventory-report" aria-label="Exporteren Inventarisatierapport pagina">Exporteren Inventarisatierapport</Link></li>
                                    <li><Link to="/vehicle-availability" aria-label="Planningsoverzicht Voertuigen pagina">Planningsoverzicht Voertuigen</Link></li>
                                </ul>
                            </li>

                            <li style={{ marginBottom: '4rem' }}>
                                <strong className="category-title" style={{ fontSize: '1.2rem', display: 'block', marginBottom: '1rem' }}>Frontofficemedewerker</strong>
                                <ul className="category-links" style={{ marginLeft: '1.2rem', listStyleType: 'circle', paddingLeft: '1rem' }}>
                                    <li><Link to="/rental-requests" aria-label="Verhuuraanvragen pagina">Verhuuraanvragen</Link></li>
                                    <li><Link to="/vehicle-issuance" aria-label="Uitgifte Voertuigen pagina">Uitgifte Voertuigen</Link></li>
                                    <li><Link to="/vehicle-issuance-notes" aria-label="Notities bij Voertuiguitgifte pagina">Notities bij Voertuiguitgifte</Link></li>
                                    <li><Link to="/search-customer-info" aria-label="Klantinformatie Zoeken pagina">Klantinformatie Zoeken</Link></li>
                                </ul>
                            </li>

                            <li style={{ marginBottom: '4rem' }}>
                                <strong className="category-title" style={{ fontSize: '1.2rem', display: 'block', marginBottom: '1rem' }}>Backofficemedewerker</strong>
                                <ul className="category-links" style={{ marginLeft: '1.2rem', listStyleType: 'circle', paddingLeft: '1rem' }}>
                                    <li><Link to="/damage-reports" aria-label="Schademeldingen pagina">Schademeldingen</Link></li>
                                    <li><Link to="/damage-cases-overview" aria-label="Schadegevallen Overzicht pagina">Schadegevallen Overzicht</Link></li>
                                    <li><Link to="/export-rental-report" aria-label="Exporteren Huur Overzicht pagina">Exporteren Huur Overzicht</Link></li>
                                    <li><Link to="/generate-invoice" aria-label="Factuur Genereren pagina">Factuur Genereren</Link></li>
                                    <li><Link to="/rental-history" aria-label="Huurgeschiedenis pagina">Huurgeschiedenis</Link></li>
                                </ul>
                            </li>
                        </ul>
                    </nav>
                </aside>
                <main className="main-content">
                    <Outlet />
                </main>
            </div>
        </div>
    );
};

export default DashboardLayout;
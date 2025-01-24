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
                                    <li><Link to="/account-instellingen" aria-label="Accountinstellingen pagina">Accountinstellingen</Link></li>
                                    <li><Link to="/zakelijke-account-instellingen" aria-label="Zakelijke Accountinstellingen pagina">Zakelijke Accountinstellingen</Link></li>
                                </ul>
                            </li>

                            <li style={{ marginBottom: '4rem' }}>
                                <strong className="category-title" style={{ fontSize: '1.2rem', display: 'block', marginBottom: '1rem' }}>Abonnementen</strong>
                                <ul className="category-links" style={{ marginLeft: '1.2rem', listStyleType: 'circle', paddingLeft: '1rem' }}>
                                    <li><Link to="/abonnement-beheer" aria-label="Abonnement Beheer pagina">Abonnement Beheer</Link></li>
                                    <li><Link to="/abonnementen-keuren" aria-label="Goedkeuren/Afwijzen Abonnementen pagina">Goedkeuren/Afwijzen Abonnementen</Link></li>
                                    <li><Link to="/openstaande-facturen" aria-label="Openstaande Facturen pagina">Openstaande Facturen</Link></li>
                                </ul>
                            </li>

                            <li style={{ marginBottom: '4rem' }}>
                                <strong className="category-title" style={{ fontSize: '1.2rem', display: 'block', marginBottom: '1rem' }}>Wagenparkbeheerder</strong>
                                <ul className="category-links" style={{ marginLeft: '1.2rem', listStyleType: 'circle', paddingLeft: '1rem' }}>
                                    <li><Link to="/wagenpark-manager" aria-label="Wagenpark Manager pagina">Wagenpark Manager</Link></li>
                                    <li><Link to="/voertuig-status-beheer" aria-label="Voertuigstatus Beheren pagina">Voertuigstatus Beheren</Link></li>
                                    <li><Link to="/voertuigen-blokkeren" aria-label="Voertuigen Blokkeren pagina">Voertuigen Blokkeren</Link></li>
                                    <li><Link to="/voorraad-rapport-exporteren" aria-label="Exporteren Voorraadrapport pagina">Exporteren Voorraadrapport</Link></li>
                                    <li><Link to="/voertuig-beschikbaarheid" aria-label="Voertuig Beschikbaarheid pagina">Voertuig Beschikbaarheid</Link></li>
                                </ul>
                            </li>

                            <li style={{ marginBottom: '4rem' }}>
                                <strong className="category-title" style={{ fontSize: '1.2rem', display: 'block', marginBottom: '1rem' }}>Frontofficemedewerker</strong>
                                <ul className="category-links" style={{ marginLeft: '1.2rem', listStyleType: 'circle', paddingLeft: '1rem' }}>
                                    <li><Link to="/huur-aanvragen" aria-label="Huur Aanvragen pagina">Huur Aanvragen</Link></li>
                                    <li><Link to="/voertuig-uitgifte" aria-label="Voertuig Uitgifte pagina">Voertuig Uitgifte</Link></li>
                                    <li><Link to="/uitgifte-notities" aria-label="Uitgifte Notities pagina">Uitgifte Notities</Link></li>
                                    <li><Link to="/klant-info-zoeken" aria-label="Klantinformatie Zoeken pagina">Klantinformatie Zoeken</Link></li>
                                </ul>
                            </li>

                            <li style={{ marginBottom: '4rem' }}>
                                <strong className="category-title" style={{ fontSize: '1.2rem', display: 'block', marginBottom: '1rem' }}>Backofficemedewerker</strong>
                                <ul className="category-links" style={{ marginLeft: '1.2rem', listStyleType: 'circle', paddingLeft: '1rem' }}>
                                    <li><Link to="/schade-rapporten" aria-label="Schade Rapporten pagina">Schade Rapporten</Link></li>
                                    <li><Link to="/schade-overzicht" aria-label="Schade Overzicht pagina">Schade Overzicht</Link></li>
                                    <li><Link to="/huur-rapport-exporteren" aria-label="Huur Rapport Exporteren pagina">Huur Rapport Exporteren</Link></li>
                                    <li><Link to="/factuur-genereren" aria-label="Factuur Genereren pagina">Factuur Genereren</Link></li>
                                    <li><Link to="/huur-geschiedenis" aria-label="Huurgeschiedenis pagina">Huurgeschiedenis</Link></li>
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

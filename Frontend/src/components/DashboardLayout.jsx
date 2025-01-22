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
                    <nav aria-label="Dashboard navigatie">
                        <ul>
                            <li><Link to="/account-settings">Account</Link></li>
                            <li><Link to="/business-account-settings">Bedrijfsaccount</Link></li>
                            <li><Link to="/fleet-manager">Zakelijke Huurders Beheren</Link></li>
                            <li><Link to="/rental-requests">Verhuuraanvragen</Link></li>
                            <li><Link to="/vehicle-overview">Overzicht Verhuurde Voertuigen</Link></li>
                            <li><Link to="/damage-reports">Schademeldingen</Link></li>
                            <li><Link to="/manage-employees">Beheer Medewerkers</Link></li>
                            <li><Link to="/vehicle-issuance">Uitgifte Voertuigen</Link></li>
                            <li><Link to="/fleet-management">Wagenparkbeheer</Link></li>
                            <li><Link to="/subscription-management">Abonnement Beheren</Link></li>
                            <li><Link to="/approve-reject-subscriptions">Goedkeuren/Afwijzen Abonnementen</Link></li>
                            <li><Link to="/vehicle-status-management">Voertuigstatus Beheren</Link></li>
                            <li><Link to="/rental-history">Huurgeschiedenis</Link></li>
                            <li><Link to="/block-vehicles">Voertuigen Blokkeren</Link></li>
                            <li><Link to="/export-rental-report">Exporteren Huur Overzicht</Link></li>
                            <li><Link to="/export-inventory-report">Exporteren Inventarisatierapport</Link></li>
                            <li><Link to="/cancel-reservation">Reservering Annuleren</Link></li>
                            <li><Link to="/vehicle-availability">Planningsoverzicht Voertuigen</Link></li>
                            <li><Link to="/search-customer-info">Klantinformatie Zoeken</Link></li>
                            <li><Link to="/generate-invoice">Factuur Genereren</Link></li>
                            <li><Link to="/outstanding-invoices">Openstaande Facturen</Link></li>
                            <li><Link to="/damage-report">Schade Melden</Link></li>
                            <li><Link to="/vehicle-issuance-notes">Notities bij Voertuiguitgifte</Link></li>
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
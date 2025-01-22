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
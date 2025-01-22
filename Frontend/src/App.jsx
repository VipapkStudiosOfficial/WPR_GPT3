// src/App.jsx

import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import DashboardLayout from './components/DashboardLayout';
import AccountSettings from './pages/AccountSettings';
import BusinessAccountSettings from './pages/BusinessAccountSettings';
import FleetManager from './pages/FleetManager';
import RentalRequests from './pages/RentalRequests';
import VehicleOverview from './pages/VehicleOverview';
import DamageReports from './pages/DamageReports';
import ManageEmployees from './pages/ManageEmployees';
import VehicleIssuance from './pages/VehicleIssuance';
import FleetManagement from './pages/FleetManagement';

const App = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<DashboardLayout />}>
          <Route path="account-settings" element={<AccountSettings />} />
          <Route path="business-account-settings" element={<BusinessAccountSettings />} />
          <Route path="fleet-manager" element={<FleetManager />} />
          <Route path="rental-requests" element={<RentalRequests />} />
          <Route path="vehicle-overview" element={<VehicleOverview />} />
          <Route path="damage-reports" element={<DamageReports />} />
          <Route path="manage-employees" element={<ManageEmployees />} />
          <Route path="vehicle-issuance" element={<VehicleIssuance />} />
          <Route path="fleet-management" element={<FleetManagement />} />
        </Route>
      </Routes>
    </Router>
  );
};

export default App;

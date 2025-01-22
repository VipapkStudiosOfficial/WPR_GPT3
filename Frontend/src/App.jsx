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
import SubscriptionManagement from './pages/SubscriptionManagement';
import ApproveRejectSubscriptions from './pages/ApproveRejectSubscriptions';
import VehicleStatusManagement from './pages/VehicleStatusManagement';
import RentalHistory from './pages/RentalHistory';
import BlockVehicles from './pages/BlockVehicles';
import ExportRentalReport from './pages/ExportRentalReport';
import ExportInventoryReport from './pages/ExportInventoryReport';
import CancelReservation from './pages/CancelReservation';
import VehicleAvailability from './pages/VehicleAvailability';
import SearchCustomerInfo from './pages/SearchCustomerInfo';
import GenerateInvoice from './pages/GenerateInvoice';
import OutstandingInvoices from './pages/OutstandingInvoices';
import DamageReport from './pages/DamageReport';
import VehicleIssuanceNotes from './pages/VehicleIssuanceNotes';

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
          <Route path="subscription-management" element={<SubscriptionManagement />} />
          <Route path="approve-reject-subscriptions" element={<ApproveRejectSubscriptions />} />
          <Route path="vehicle-status-management" element={<VehicleStatusManagement />} />
          <Route path="rental-history" element={<RentalHistory />} />
          <Route path="block-vehicles" element={<BlockVehicles />} />
          <Route path="export-rental-report" element={<ExportRentalReport />} />
          <Route path="export-inventory-report" element={<ExportInventoryReport />} />
          <Route path="cancel-reservation" element={<CancelReservation />} />
          <Route path="vehicle-availability" element={<VehicleAvailability />} />
          <Route path="search-customer-info" element={<SearchCustomerInfo />} />
          <Route path="generate-invoice" element={<GenerateInvoice />} />
          <Route path="outstanding-invoices" element={<OutstandingInvoices />} />
          <Route path="damage-report" element={<DamageReport />} />
          <Route path="vehicle-issuance-notes" element={<VehicleIssuanceNotes />} />
        </Route>
      </Routes>
    </Router>
  );
};

export default App;

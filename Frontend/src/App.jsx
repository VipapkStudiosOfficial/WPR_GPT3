// src/App.jsx

import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import DashboardLayout from './components/DashboardLayout';
import AccountInstellingen from './pages/AccountInstellingen';
import ZakelijkeAccountInstellingen from './pages/ZakelijkeAccountInstellingen';
import WagenparkManager from './pages/WagenparkManager';
import HuurAanvragen from './pages/HuurAanvragen';
import VoertuigOverzicht from './pages/VoertuigOverzicht';
import SchadeRapporten from './pages/SchadeRapporten';
import MedewerkersBeheren from './pages/MedewerkersBeheren';
import VoertuigUitgifte from './pages/VoertuigUitgifte';
import WagenparkBeheer from './pages/WagenparkBeheer';
import AbonnementBeheer from './pages/AbonnementBeheer';
import AbonnementenKeuren from './pages/AbonnementenKeuren';
import VoertuigStatusBeheer from './pages/VoertuigStatusBeheer';
import HuurGeschiedenis from './pages/HuurGeschiedenis';
import VoertuigenBlokkeren from './pages/VoertuigenBlokkeren';
import HuurRapportExporteren from './pages/HuurRapportExporteren';
import VoorraadRapportExporteren from './pages/VoorraadRapportExporteren';
import ReserveringAnnuleren from './pages/ReserveringAnnuleren';
import VoertuigBeschikbaarheid from './pages/VoertuigBeschikbaarheid';
import KlantInfoZoeken from './pages/KlantInfoZoeken';
import FactuurGenereren from './pages/FactuurGenereren';
import OpenstaandeFacturen from './pages/OpenstaandeFacturen';
import SchadeMelden from './pages/SchadeMelden';
import UitgifteNotities from './pages/UitgifteNotities';
import MaandgebruikRapport from './pages/MaandgebruikRapport';
import SchadeOverzicht from './pages/SchadeOverzicht';

const App = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<DashboardLayout />}>
          <Route path="account-instellingen" element={<AccountInstellingen />} />
          <Route path="zakelijke-account-instellingen" element={<ZakelijkeAccountInstellingen />} />
          <Route path="wagenpark-manager" element={<WagenparkManager />} />
          <Route path="huur-aanvragen" element={<HuurAanvragen />} />
          <Route path="voertuig-overzicht" element={<VoertuigOverzicht />} />
          <Route path="schade-rapporten" element={<SchadeRapporten />} />
          <Route path="medewerkers-beheren" element={<MedewerkersBeheren />} />
          <Route path="voertuig-uitgifte" element={<VoertuigUitgifte />} />
          <Route path="wagenpark-beheer" element={<WagenparkBeheer />} />
          <Route path="abonnement-beheer" element={<AbonnementBeheer />} />
          <Route path="abonnementen-keuren" element={<AbonnementenKeuren />} />
          <Route path="voertuig-status-beheer" element={<VoertuigStatusBeheer />} />
          <Route path="huur-geschiedenis" element={<HuurGeschiedenis />} />
          <Route path="voertuigen-blokkeren" element={<VoertuigenBlokkeren />} />
          <Route path="huur-rapport-exporteren" element={<HuurRapportExporteren />} />
          <Route path="voorraad-rapport-exporteren" element={<VoorraadRapportExporteren />} />
          <Route path="reservering-annuleren" element={<ReserveringAnnuleren />} />
          <Route path="voertuig-beschikbaarheid" element={<VoertuigBeschikbaarheid />} />
          <Route path="klant-info-zoeken" element={<KlantInfoZoeken />} />
          <Route path="factuur-genereren" element={<FactuurGenereren />} />
          <Route path="openstaande-facturen" element={<OpenstaandeFacturen />} />
          <Route path="schade-melden" element={<SchadeMelden />} />
          <Route path="uitgifte-notities" element={<UitgifteNotities />} />
          <Route path="maandgebruik-rapport" element={<MaandgebruikRapport />} />
          <Route path="schade-overzicht" element={<SchadeOverzicht />} />
        </Route>
      </Routes>
    </Router>
  );
};

export default App;

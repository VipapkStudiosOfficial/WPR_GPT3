import React, { useState, useEffect } from 'react';
import '../styles/VoertuigOverzicht.css';

const VehicleOverview = () => {
    const [vehicles, setVehicles] = useState([]);
    const [filters, setFilters] = useState({
        type: '',
        huurder: '',
        startDatum: '',
        eindDatum: '',
    });
    const [isExporting, setIsExporting] = useState(false);

    useEffect(() => {
        fetch('/api/voertuig')
            .then((response) => {
                if (!response.ok) {
                    throw new Error('Netwerkrespons was niet OK');
                }
                return response.json();
            })
            .then((data) => setVehicles(data))
            .catch((error) => console.error('Fout bij het ophalen van voertuigen:', error));
    }, []);

    const handleFilterChange = (e) => {
        const { name, value } = e.target;
        setFilters((prev) => ({ ...prev, [name]: value }));
    };

    const applyFilters = () => {
        fetch('/api/voertuig/filter', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(filters),
        })
            .then((response) => {
                if (!response.ok) {
                    throw new Error('Netwerkrespons was niet OK');
                }
                return response.json();
            })
            .then((data) => setVehicles(data))
            .catch((error) => console.error('Fout bij het toepassen van filters:', error));
    };

    const exportData = (format) => {
        setIsExporting(true);
        fetch(`/api/voertuig/export?format=${format}`)
            .then((response) => {
                console.log('API Response:', response);
                if (!response.ok) {
                    throw new Error('Netwerkrespons was niet OK');
                }
                return response.blob();
            })
            .then((blob) => {
                const url = window.URL.createObjectURL(blob);
                const link = document.createElement('a');
                link.href = url;
                link.setAttribute('download', `vehicles.${format}`);
                document.body.appendChild(link);
                link.click();
            })
            .catch((error) => console.error('Fout bij het exporteren van data:', error))
            .finally(() => setIsExporting(false));
    };

    return (
        <div className="vehicle-overview">
            <h1>Overzicht van Verhuurde Voertuigen</h1>
            <div className="filters">
                <label>Type:</label>
                <select name="type" value={filters.type} onChange={handleFilterChange}>
                    <option value="">Alle</option>
                    <option value="Auto">Auto</option>
                    <option value="Camper">Camper</option>
                </select>
                <label>Huurder:</label>
                <input type="text" name="huurder" value={filters.huurder} onChange={handleFilterChange} />
                <label>Startdatum:</label>
                <input type="date" name="startDatum" value={filters.startDatum} onChange={handleFilterChange} />
                <label>Einddatum:</label>
                <input type="date" name="eindDatum" value={filters.eindDatum} onChange={handleFilterChange} />
                <button onClick={applyFilters}>Filter</button>
            </div>
            <table className="vehicles-table">
                <thead>
                    <tr>
                        <th>Type</th>
                        <th>Merk</th>
                        <th>Model</th>
                        <th>Prijs</th>
                        <th>Huurder</th>
                        <th>Verhuurdatum</th>
                    </tr>
                </thead>
                <tbody>
                    {vehicles.length > 0 ? (
                        vehicles.map((vehicle) => (
                            <tr key={vehicle.voertuigId}>
                                <td>{vehicle.type}</td>
                                <td>{vehicle.merk}</td>
                                <td>{vehicle.model}</td>
                                <td>€{vehicle.prijs}</td>
                                <td>{vehicle.huurder || 'N/A'}</td>
                                <td>{vehicle.verhuurDatum ? new Date(vehicle.verhuurDatum).toLocaleDateString() : 'N/A'}</td>
                            </tr>
                        ))
                    ) : (
                        <tr>
                            <td colSpan="6">Geen voertuigen gevonden.</td>
                        </tr>
                    )}
                </tbody>
            </table>
            <button onClick={() => exportData('csv')} disabled={isExporting}>
                {isExporting ? 'Exporteren...' : 'Exporteer als CSV'}
            </button>
            <button onClick={() => exportData('pdf')} disabled={isExporting}>
                {isExporting ? 'Exporteren...' : 'Exporteer als PDF'}
            </button>
        </div>
    );
};

export default VehicleOverview;

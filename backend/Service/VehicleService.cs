using System;
using System.Collections.Generic;
using System.Linq;
using backend.Data;
using backend.Dtos.Voertuig;
using backend.Mappers;
using backend.Models;

public class VehicleService : IVehicleService
{
    private readonly ApplicationDBContext _context;

    public VehicleService(ApplicationDBContext context)
    {
        _context = context;
    }

    public List<VoertuigDto> GetAllVehicles()
    {
        return _context.Voertuigen
            .Select(v => v.ToVoertuigDto())
            .ToList();
    }

    public List<VoertuigDto> FilterVehicles(VoertuigDto filter)
    {
        var query = _context.Voertuigen.AsQueryable();

        if (!string.IsNullOrEmpty(filter.Type))
            query = query.Where(v => v.Type == filter.Type);

        if (!string.IsNullOrEmpty(filter.Huurder))
            query = query.Where(v => v.Huurder.Contains(filter.Huurder));

        if (filter.StartDatum.HasValue)
            query = query.Where(v => v.VerhuurDatum >= filter.StartDatum.Value);

        if (filter.EindDatum.HasValue)
            query = query.Where(v => v.VerhuurDatum <= filter.EindDatum.Value);

        return query.Select(v => v.ToVoertuigDto()).ToList();
    }

    public byte[] ExportVehicles(string format)
    {
        var vehicles = GetAllVehicles();
        if (format == "csv")
        {
            // CSV Export logic here
        }
        else if (format == "pdf")
        {
            // PDF Export logic here
        }
        return new byte[0]; // Placeholder for actual implementation
    }
}

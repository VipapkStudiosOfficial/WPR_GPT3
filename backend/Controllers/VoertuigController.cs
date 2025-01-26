using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Data;
using backend.Dtos.Voertuig;
using backend.Interfaces;
using backend.Mappers;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace backend.Controllers
{
    [Route("api/voertuig")]
    [ApiController]
    public class VoertuigController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IVoertuigRepository _voertuigRepo;

        public VoertuigController(ApplicationDBContext context, IVoertuigRepository voertuigRepo)
        {
            _context = context;
            _voertuigRepo = voertuigRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var voertuigen = _context.Voertuigen.ToList();
            return Ok(voertuigen);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var voertuig = _context.Voertuigen.FirstOrDefault(v => v.VoertuigId == id);
            if (voertuig == null)
            {
                return NotFound();
            }
            return Ok(voertuig);
        }

        [HttpPost("filter")]
        public IActionResult FilterVehicles([FromBody] VoertuigDto filter)
        {
            var query = _context.Voertuigen.AsQueryable();

            if (!string.IsNullOrEmpty(filter.Type))
                query = query.Where(v => v.Type == filter.Type);

            if (!string.IsNullOrEmpty(filter.Huurder))
                query = query.Where(v => v.Huurder.Contains(filter.Huurder));

            if (filter.StartDatum.HasValue)
                query = query.Where(v => v.VerhuurDatum >= filter.StartDatum);

            if (filter.EindDatum.HasValue)
                query = query.Where(v => v.VerhuurDatum <= filter.EindDatum);

            var filteredVehicles = query.ToList();
            return Ok(filteredVehicles);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] VoertuigCreateDto voertuigCreateDto)
        {
            var voertuigModel = voertuigCreateDto.ToCreateVoertuigDto();
            await _voertuigRepo.CreateVoertuigAsync(voertuigModel);
            return CreatedAtAction(nameof(GetById), new { id = voertuigModel.VoertuigId }, voertuigModel);
        }

        [HttpGet("export")]
        public IActionResult ExportVehicles([FromQuery] string format)
        {
            var vehicles = _context.Voertuigen.ToList();

            if (format.ToLower() == "csv")
            {
                var csv = GenerateCsv(vehicles);
                return File(csv, "text/csv", "vehicles.csv");
            }
            else if (format.ToLower() == "pdf")
            {
                var pdf = GeneratePdf(vehicles);
                return File(pdf, "application/pdf", "vehicles.pdf");
            }

            return BadRequest("Ongeldig formaat. Gebruik 'csv' of 'pdf'.");
        }

        private byte[] GenerateCsv(List<Voertuig> vehicles)
        {
            var csv = new StringBuilder();
            csv.AppendLine("VoertuigId,Type,Merk,Model,Kenteken,Kleur,Status,Prijs,Huurder,VerhuurDatum");

            foreach (var vehicle in vehicles)
            {
                csv.AppendLine($"{vehicle.VoertuigId},{vehicle.Type},{vehicle.Merk},{vehicle.Model},{vehicle.Kenteken},{vehicle.Kleur},{vehicle.Status},{vehicle.Prijs},{vehicle.Huurder},{vehicle.VerhuurDatum?.ToString("yyyy-MM-dd")}");
            }

            return Encoding.UTF8.GetBytes(csv.ToString());
        }

        private byte[] GeneratePdf(List<Voertuig> vehicles)
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(20);
                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                        });

                        table.Header(header =>
                        {
                            header.Cell().Text("VoertuigId").Bold();
                            header.Cell().Text("Type").Bold();
                            header.Cell().Text("Merk").Bold();
                            header.Cell().Text("Model").Bold();
                            header.Cell().Text("Kenteken").Bold();
                            header.Cell().Text("Status").Bold();
                            header.Cell().Text("Prijs").Bold();
                            header.Cell().Text("Huurder").Bold();
                            header.Cell().Text("VerhuurDatum").Bold();
                        });

                        foreach (var vehicle in vehicles)
                        {
                            table.Cell().Text(vehicle.VoertuigId.ToString());
                            table.Cell().Text(vehicle.Type);
                            table.Cell().Text(vehicle.Merk);
                            table.Cell().Text(vehicle.Model);
                            table.Cell().Text(vehicle.Kenteken);
                            table.Cell().Text(vehicle.Status);
                            table.Cell().Text($"€{vehicle.Prijs:F2}");
                            table.Cell().Text(vehicle.Huurder ?? "N/A");
                            table.Cell().Text(vehicle.VerhuurDatum?.ToString("yyyy-MM-dd") ?? "N/A");
                        }
                    });
                });
            });

            using (var stream = new MemoryStream())
            {
                document.GeneratePdf(stream);
                return stream.ToArray();
            }
        }
    }
}

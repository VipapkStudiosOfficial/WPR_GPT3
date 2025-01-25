using System.Threading.Tasks;
using backend.Dtos.Schade;
using backend.Models;
using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchadeController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public SchadeController(ApplicationDBContext context)
        {
            _context = context;
        }

        // POST: api/Schade
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SchadeCreateDto schadeCreateDto)
        {
            // Validatie van HuurAanvraagId
            var huurAanvraag = await _context.HuurAanvragen.FindAsync(schadeCreateDto.HuurAanvraagId);
            if (huurAanvraag == null)
            {
                return BadRequest("Ongeldig HuurAanvraagId. De huuraanvraag bestaat niet.");
            }

            // Validatie van VoertuigId
            var voertuig = await _context.Voertuigen.FindAsync(schadeCreateDto.VoertuigId);
            if (voertuig == null)
            {
                return BadRequest("Ongeldig VoertuigId. Het voertuig bestaat niet.");
            }

            // Maak een nieuw Schade-object
            var schade = new Schade
            {
                HuurAanvraagId = schadeCreateDto.HuurAanvraagId,
                VoertuigId = schadeCreateDto.VoertuigId,
                Beschrijving = schadeCreateDto.Beschrijving,
                SchadeDatum = schadeCreateDto.SchadeDatum,
                FotoUrls = schadeCreateDto.FotoUrls.Select(url => new FotoUrl { Url = url }).ToList(),
                Schademelder = schadeCreateDto.Schademelder,
                Status = "Open" // Standaard status bij aanmaak
            };

            // Opslaan in de database
            await _context.Schades.AddAsync(schade);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = schade.SchadeId }, schade);
        }

        // GET: api/Schade/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var schade = await _context.Schades
                .Include(s => s.FotoUrls)
                .Include(s => s.HuurAanvraag)
                .Include(s => s.Voertuig)
                .FirstOrDefaultAsync(s => s.SchadeId == id);

            if (schade == null)
            {
                return NotFound("Schade niet gevonden.");
            }

            var schadeDto = new SchadeDto
            {
                SchadeId = schade.SchadeId,
                HuurderNaam = schade.HuurAanvraag?.Naam ?? "Onbekend",
                VoertuigNaam = schade.Voertuig?.Merk + " " + schade.Voertuig?.Model ?? "Onbekend",
                Beschrijving = schade.Beschrijving,
                SchadeDatum = schade.SchadeDatum,
                FotoUrls = schade.FotoUrls.Select(f => f.Url).ToList(),
                ReparatieOpmerkingen = schade.ReparatieOpmerkingen,
                Status = schade.Status,
                Schademelder = schade.Schademelder
            };

            return Ok(schadeDto);
        }

        // PUT: api/Schade/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SchadeUpdateDto schadeUpdateDto)
        {
            var schade = await _context.Schades.FindAsync(id);
            if (schade == null)
            {
                return NotFound("Schade niet gevonden.");
            }

            // Update velden
            if (!string.IsNullOrEmpty(schadeUpdateDto.Status))
            {
                schade.Status = schadeUpdateDto.Status;
            }

            if (!string.IsNullOrEmpty(schadeUpdateDto.ReparatieOpmerkingen))
            {
                schade.ReparatieOpmerkingen = schadeUpdateDto.ReparatieOpmerkingen;
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/Schade/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var schade = await _context.Schades.FindAsync(id);
            if (schade == null)
            {
                return NotFound("Schade niet gevonden.");
            }

            _context.Schades.Remove(schade);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

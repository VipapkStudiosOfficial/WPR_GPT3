using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Schade;
using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/schade")]
    [ApiController]
    public class SchadeController : ControllerBase
    {
        private readonly ISchadeRepository _schadeRepository;
        private readonly IHuurAanvraagRepository _huurAanvraagRepository;

        public SchadeController(ISchadeRepository schadeRepository, IHuurAanvraagRepository huurAanvraagRepository)
        {
            _schadeRepository = schadeRepository;
            _huurAanvraagRepository = huurAanvraagRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var schades = await _schadeRepository.GetAllAsync();
            return Ok(schades.Select(s => new SchadeDto
            {
                SchadeId = s.SchadeId,
                HuurderNaam = s.HuurAanvraag?.Naam ?? "Onbekend",
                VoertuigNaam = s.HuurAanvraag?.Voertuig?.Naam ?? "Onbekend",
                Beschrijving = s.Beschrijving,
                SchadeDatum = s.SchadeDatum,
                FotoUrls = s.FotoUrls.Select(f => f.Url).ToList(),
                ReparatieOpmerkingen = s.ReparatieOpmerkingen,
                Status = s.Status,
                Schademelder = s.HuurAanvraag?.Naam ?? "Onbekend"
            }));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var schade = await _schadeRepository.GetByIdAsync(id);
            if (schade == null) return NotFound();

            return Ok(new SchadeDto
            {
                SchadeId = schade.SchadeId,
                HuurderNaam = schade.HuurAanvraag?.Naam ?? "Onbekend",
                VoertuigNaam = schade.HuurAanvraag?.Voertuig?.Naam ?? "Onbekend",
                Beschrijving = schade.Beschrijving,
                SchadeDatum = schade.SchadeDatum,
                FotoUrls = schade.FotoUrls.Select(f => f.Url).ToList(),
                ReparatieOpmerkingen = schade.ReparatieOpmerkingen,
                Status = schade.Status,
                Schademelder = schade.HuurAanvraag?.Naam ?? "Onbekend"
            });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SchadeCreateDto schadeCreateDto)
        {
            var huurAanvraag = await _huurAanvraagRepository.GetByIdAsync(schadeCreateDto.HuurAanvraagId);
            if (huurAanvraag == null)
            {
                return BadRequest("HuurAanvraag niet gevonden.");
            }

            var schade = new Schade
            {
                HuurAanvraagId = schadeCreateDto.HuurAanvraagId,
                Beschrijving = schadeCreateDto.Beschrijving,
                SchadeDatum = schadeCreateDto.SchadeDatum,
                FotoUrls = schadeCreateDto.FotoUrls.Select(url => new FotoUrl { Url = url }).ToList(),
                Status = "Open",
                ReparatieOpmerkingen = string.Empty
            };

            await _schadeRepository.CreateAsync(schade);
            return CreatedAtAction(nameof(GetById), new { id = schade.SchadeId }, schade);
        }

        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateStatus(int id, [FromBody] string status)
        {
            var schade = await _schadeRepository.GetByIdAsync(id);
            if (schade == null) return NotFound();

            schade.Status = status;
            await _schadeRepository.UpdateAsync(schade);
            return Ok(schade);
        }

        [HttpPost("{id}/opmerking")]
        public async Task<IActionResult> AddOpmerking(int id, [FromBody] string opmerking)
        {
            var schade = await _schadeRepository.GetByIdAsync(id);
            if (schade == null) return NotFound();

            schade.ReparatieOpmerkingen += $"{opmerking}\n";
            await _schadeRepository.UpdateAsync(schade);
            return Ok(schade);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _schadeRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
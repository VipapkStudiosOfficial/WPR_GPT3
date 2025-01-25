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

        public SchadeController(ISchadeRepository schadeRepository)
        {
            _schadeRepository = schadeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var schades = await _schadeRepository.GetAllAsync();
            return Ok(schades.Select(s => new SchadeDto
            {
                SchadeId = s.SchadeId,
                VoertuigId = s.VoertuigId,
                Beschrijving = s.Beschrijving,
                SchadeDatum = s.SchadeDatum,
                FotoUrls = s.FotoUrls.Select(f => f.Url).ToList(), // URLs ophalen
                ReparatieOpmerkingen = s.ReparatieOpmerkingen,
                Status = s.Status
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
                VoertuigId = schade.VoertuigId,
                Beschrijving = schade.Beschrijving,
                SchadeDatum = schade.SchadeDatum,
                FotoUrls = schade.FotoUrls.Select(f => f.Url).ToList(), // Haal de URL's op
                ReparatieOpmerkingen = schade.ReparatieOpmerkingen,
                Status = schade.Status
            });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SchadeCreateDto schadeCreateDto)
        {
            var schade = new Schade
            {
                VoertuigId = schadeCreateDto.VoertuigId,
                Beschrijving = schadeCreateDto.Beschrijving,
                SchadeDatum = schadeCreateDto.SchadeDatum,
                FotoUrls = schadeCreateDto.FotoUrls.Select(url => new FotoUrl { Url = url }).ToList(),
                Status = "Open"
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

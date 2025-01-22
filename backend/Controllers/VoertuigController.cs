using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dtos.Voertuig;
using backend.Interfaces;
using backend.Mappers;
using Microsoft.AspNetCore.Mvc;

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
            _voertuigRepo = voertuigRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            var voertuigen = await _voertuigRepo.GetAllAsync();
            var voertuigDto = voertuigen.Select(s => s.ToVoertuigDto());

            return Ok(voertuigDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var voertuig = await _voertuigRepo.GetByIdAsync(id);
            if (voertuig == null) return NotFound();
            return Ok(voertuig.ToVoertuigDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] VoertuigCreateDto voertuigCreateDto)
        {
            var voertuigModel = voertuigCreateDto.ToCreateVoertuigDto();
            await _voertuigRepo.CreateVoertuigAsync(voertuigModel);
            return CreatedAtAction(nameof(GetById), new { id = voertuigModel.VoertuigId }, voertuigModel.ToVoertuigDto()); // voertuig.Id moet nu correct werken
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] VoertuigUpdateDto voertuigUpdateDto)
        {
            var voertuigModel = await _voertuigRepo.UpdateAsync(id, voertuigUpdateDto);
            if (voertuigModel == null)
            {
                return NotFound();
            }
            return Ok(voertuigModel.ToVoertuigDto());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var voertuigModel = await _voertuigRepo.DeleteAsync(id);

            if (voertuigModel == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
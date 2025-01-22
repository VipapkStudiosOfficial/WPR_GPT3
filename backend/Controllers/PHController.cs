using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dtos.Klant;
using backend.Interfaces;
using backend.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/ph")]
    [ApiController]
    public class PHController: ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IPHRepository _pHRepo;
        public PHController(ApplicationDBContext context, IPHRepository pHRepo)
        {
            _pHRepo = pHRepo;
            _context = context;
        }

        [HttpGet]
        [Authorize (Roles = "User")]
        public async Task<IActionResult> GetAll(){
            var klants = await _pHRepo.GetAllAsync();
            var klantDto = klants.Select(s => s.ToPHDto());

            return Ok(klantDto);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetById([FromRoute] int id){
            var pH = await _pHRepo.GetByIdAsync(id);

            if(pH == null){
                return NotFound();
            }
            return Ok(pH.ToPHDto());
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePHRequestDto pHDto){
            var pHModel = pHDto.ToPHFromCreateDTO();
            await _pHRepo.CreateAsync(pHModel);
            return CreatedAtAction(nameof(GetById), new { id = pHModel.PHId} , pHModel.ToPHDto());
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePHDto UpdateDto){
            var pHModel = await _pHRepo.UpdateAsync(id, UpdateDto);
            if(pHModel == null){
                return NotFound();
            }

            return Ok(pHModel.ToPHDto());
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id){
            var pHModel = await _pHRepo.DeleteAsync(id);

            if(pHModel == null){
                return NotFound();
            }

            return NoContent();
        }
    }
}
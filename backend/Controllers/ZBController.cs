using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dtos.ZB;
using backend.Interfaces;
using backend.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace backend.Controllers
{
    [Route("/api/ZB")]
    [ApiController]
    public class ZBController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IZBRepository _zBRepo;
        public ZBController(ApplicationDBContext context, IZBRepository zBRepo)
        {
            _zBRepo = zBRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            var zBs = await _zBRepo.GetAllAsync();
            var zBDto = zBs.Select(s => s.ToZBDto());

            return Ok(zBDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id){
            var zB = await _zBRepo.GetByIdAsync(id);

            if(zB == null){
                return NotFound();
            }
            return Ok(zB.ToZBDto());
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateZBRequestDto zBDto){
            var zBModel = zBDto.ToZBFromCreateDTO();
            await _zBRepo.CreateAsync(zBModel);
            return CreatedAtAction(nameof(GetById), new { id = zBModel.ZBId} , zBModel.ToZBDto());
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateZBDto UpdateDto){
            var zBModel = await _zBRepo.UpdateAsync(id, UpdateDto);
            if(zBModel == null){
                return NotFound();
            }

            return Ok(zBModel.ToZBDto());
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id){
            var zBModel = await _zBRepo.DeleteAsync(id);

            if(zBModel == null){
                return NotFound();
            }

            return NoContent();
        }
    }
}
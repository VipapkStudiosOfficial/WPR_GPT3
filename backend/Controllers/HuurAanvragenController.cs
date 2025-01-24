using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("api/huur-aanvragen")]
    [ApiController]
    public class HuurAanvragenController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public HuurAanvragenController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/huur-aanvragen
        [HttpGet]
        public async Task<IActionResult> GetHuurAanvragen()
        {
            var aanvragen = await _context.HuurAanvragen.ToListAsync();
            if (aanvragen == null || aanvragen.Count == 0)
            {
                return NotFound("Geen huur aanvragen beschikbaar.");
            }
            return Ok(aanvragen);
        }

        // POST: api/huur-aanvragen/{id}/approve
        [HttpPost("{id}/approve")]
        public async Task<IActionResult> ApproveHuurAanvraag(int id)
        {
            var aanvraag = await _context.HuurAanvragen.FindAsync(id);
            if (aanvraag == null)
            {
                return NotFound("Aanvraag niet gevonden.");
            }

            aanvraag.Status = "Approved";
            _context.HuurAanvragen.Update(aanvraag);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Aanvraag goedgekeurd.", Aanvraag = aanvraag });
        }

        // POST: api/huur-aanvragen/{id}/reject
        [HttpPost("{id}/reject")]
        public async Task<IActionResult> RejectHuurAanvraag(int id, [FromBody] RejectRequest rejectRequest)
        {
            var aanvraag = await _context.HuurAanvragen.FindAsync(id);
            if (aanvraag == null)
            {
                return NotFound("Aanvraag niet gevonden.");
            }

            if (string.IsNullOrEmpty(rejectRequest.Reason))
            {
                return BadRequest("Afwijzingsreden is vereist.");
            }

            aanvraag.Status = "Rejected";
            aanvraag.RejectReason = rejectRequest.Reason;
            _context.HuurAanvragen.Update(aanvraag);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Aanvraag afgewezen.", Aanvraag = aanvraag });
        }
    }

    // Model for reject request
    public class RejectRequest
    {
        public string Reason { get; set; } = string.Empty;
    }
}

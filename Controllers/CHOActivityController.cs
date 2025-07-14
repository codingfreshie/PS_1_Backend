using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PS_1_Backend.Data;
using PS_1_Backend.DTOs;
using PS_1_Backend.Models;

namespace PS_1_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CHOActivityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CHOActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CHOActivity?hsc=HSC-1&year=2023-2024&month=April
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CHOActivityResponse>>> GetActivities(
            [FromQuery] string hsc,
            [FromQuery] string year,
            [FromQuery] string month)
        {
            var results = await _context.CHO_Activities
                .Where(a => a.HSc_List == hsc
                         && a.Finanicial_Year_list == year
                         && a.Financial_Month_List == month)
                .Select(a => new CHOActivityResponse
                {
                    ASHA = a.ASHA,
                    ANM = a.ANM,
                    CHO = a.CHO
                })
                .ToListAsync();

            if (results == null || results.Count == 0)
            {
                return NotFound("No data found for the given parameters.");
            }

            return Ok(results);
        }
    }
}

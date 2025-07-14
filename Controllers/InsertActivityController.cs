using Microsoft.AspNetCore.Mvc;
using PS_1_Backend.Data;
using PS_1_Backend.DTOs;
using PS_1_Backend.Models;

namespace PS_1_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsertActivityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InsertActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody] InsertActivityRequest request)
        {
            if (request.Denominator == 0)
                return BadRequest("Denominator cannot be zero.");

            var activity = new Insert_Activity
            {
                Source_of_Verification = request.Source_of_Verification,
                Denominator = request.Denominator,
                Numerator = request.Numerator,
                CHO_Name = request.CHO_Name,
                Work_Percentage = (double)request.Numerator / request.Denominator * 100
            };

            _context.Insert_Activities.Add(activity);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Activity inserted successfully.",
                activity
            });
        }
    }
}

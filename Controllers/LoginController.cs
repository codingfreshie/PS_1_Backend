using Microsoft.AspNetCore.Mvc;
using PS_1_Backend.Data;
using PS_1_Backend.DTOs;

namespace PS_1_Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginController(ApplicationDbContext context) : ControllerBase
{
    private readonly ApplicationDbContext _context = context;

    [HttpPost]
    public IActionResult Login(LoginRequest request)
    {
        var user = _context.Users
            .FirstOrDefault(u => u.Username == request.Username && u.Password == request.Password);

        if (user == null)
            return Unauthorized("Invalid username or password");

        return Ok("Login successful");
    }
}

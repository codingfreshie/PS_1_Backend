using System.ComponentModel.DataAnnotations;

namespace PS_1_Backend.DTOs;

public class LoginRequest
{
    [Required]
    public string Username { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;
}

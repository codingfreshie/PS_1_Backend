using System.ComponentModel.DataAnnotations;

namespace PS_1_Backend.DTOs;

public class RegisterRequest
{
    [Required]
    public string Username { get; set; } = null!;

    [Required]
    public string FullName { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    [MinLength(6)]
    public string Password { get; set; } = null!;

    [Required]
    [Phone]
    public string PhoneNumber { get; set; } = null!;
    [Required]
    public string District_Name { get; set; } = string.Empty;
    [Required]

    public string Block_Name { get; set; } = string.Empty;
}

﻿using System.ComponentModel.DataAnnotations;

namespace PS_1_Backend.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; } = null!;

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    [Required]
    public string PhoneNumber { get; set; } = null!;
    [Required]
    public string District_Name { get; set; } = string.Empty;
    [Required]

    public string Block_Name { get; set; } = string.Empty;
}

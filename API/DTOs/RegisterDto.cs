﻿using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] public string Username { get; set; } = string.Empty;
        [Required] public string KonwnAs { get; set; } = string.Empty;
        [Required] public string Gender { get; set; } = string.Empty;
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public string City { get; set; } = string.Empty;
        [Required] public string Country { get; set; } = string.Empty;

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; } = string.Empty;
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Nombres { get; set; } = string.Empty;
        [Required]
        public string ApellidoPaterno { get; set; } = string.Empty;
        [Required]
        public string ApellidoMaterno { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}

﻿using System.ComponentModel.DataAnnotations;
namespace TechFix.API.Model
{
    public class Customer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


    }
}

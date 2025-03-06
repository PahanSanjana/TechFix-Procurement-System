using System.ComponentModel.DataAnnotations;
namespace TechFix.API.Model
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Location{ get; set; }
        [Required]
        public int ContactNumber { get;}

        [Required]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}

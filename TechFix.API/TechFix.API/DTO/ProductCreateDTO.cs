using System.ComponentModel.DataAnnotations;
namespace TechFix.API.DTO
{
    public class ProductCreateDTO
    {
       
        public int Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Category { get; set; }
        public string Description { get; set; }
        [Required]
        public int Stock { get; set; }
    }
}

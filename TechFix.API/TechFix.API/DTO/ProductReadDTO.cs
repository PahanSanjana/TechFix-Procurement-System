

namespace TechFix.API.DTO
{
    public class ProductReadDTO
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }
        public string Description { get; set; }

        public int Stock { get; set; }
    }
}

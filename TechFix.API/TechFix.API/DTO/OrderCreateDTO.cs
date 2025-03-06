using System.ComponentModel.DataAnnotations;
namespace TechFix.API.DTO
{
    public class OrderCreateDTO
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string DateOfOrder { get; set; }
        [Required]
        public string DateOfDelivery { get; set; }
        [Required]
        public string OrderStatus { get; set; }
        [Required]
        public string DeliveryLocation { get; set; }
    }
}

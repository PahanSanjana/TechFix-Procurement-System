using System.ComponentModel.DataAnnotations;
namespace TechFix.API.Model
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SaleBy {get; set; }
        [Required]
        public string Date { get; set;}
        [Required]
        public string Time { get; set;}
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public int ProductId {  get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set;}
        [Required]
        public decimal Price { get; set;}
        [Required]
        public decimal Amount { get; set;}
        [Required]
        public decimal TotalAmount { get; set;}
        [Required]
        public string PaymentMethod { get; set; }


    }
}

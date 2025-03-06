

namespace TechFix.API.DTO
{
    public class SaleReadDTO
    {
        public int Id { get; set; }
       
        public string SaleBy { get; set; }
        
        public string Date { get; set; }
      
        public string Time { get; set; }
       
        public string CustomerName { get; set; }
    
        public int ProductId { get; set; }
        
        public string ProductName { get; set; }
       
        public int Quantity { get; set; }
        
        public decimal Price { get; set; }
       
        public decimal Amount { get; set; }
        
        public decimal TotalAmount { get; set; }
        
        public string PaymentMethod { get; set; }
    }
}

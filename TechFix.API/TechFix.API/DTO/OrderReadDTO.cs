

namespace TechFix.API.DTO
{
    public class OrderReadDTO
    {
        public int Id { get; set; }
        
        public string ProductName { get; set; }
       
        public int Quantity { get; set; }
        
        public string CustomerName { get; set; }
        
        public string DateOfOrder { get; set; }
        
        public string DateOfDelivery { get; set; }
        
        public string OrderStatus { get; set; }
        
        public string DeliveryLocation { get; set; }
    }
}



namespace TechFix.API.DTO
{
    public class CustomerReadDTO
    {
        
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public string Email { get; set; }
        
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}



namespace TechFix.API.DTO
{
    public class UserReadDTO
    {
        
        public int Id { get; set; }
      
        public string Type { get; set; }
       
        public string Location { get; set; }
        
        public int ContactNumber { get; }

        
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}

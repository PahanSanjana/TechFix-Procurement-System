using AutoMapper;
using TechFix.API.Model;
using TechFix.API.DTO;
namespace TechFix.API.Profiles
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerCreateDTO, Customer>();
            CreateMap<Customer, CustomerReadDTO>();
        }
    }
}

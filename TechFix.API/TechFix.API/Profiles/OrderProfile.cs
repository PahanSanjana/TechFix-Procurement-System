using AutoMapper;
using TechFix.API.Model;
using TechFix.API.DTO;
namespace TechFix.API.Profiles
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderCreateDTO, Order>();
            CreateMap<Order, OrderReadDTO>();
        }
    }
}

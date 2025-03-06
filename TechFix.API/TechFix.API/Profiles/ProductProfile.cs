using AutoMapper;
using TechFix.API.Model;
using TechFix.API.DTO;
namespace TechFix.API.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductCreateDTO, Product>();
            CreateMap<Product, ProductReadDTO>();
        }
    }
}


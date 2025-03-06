using AutoMapper;
using TechFix.API.Model;
using TechFix.API.DTO;
namespace TechFix.API.Profiles
{
    public class SaleProfile:Profile
    {
        public SaleProfile()
        {
            CreateMap<SaleCreateDTO, Sale>();
            CreateMap<Sale, SaleReadDTO>();
        }
    }
}

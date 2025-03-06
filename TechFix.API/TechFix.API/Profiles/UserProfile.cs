using AutoMapper;
using TechFix.API.Model;
using TechFix.API.DTO;
namespace TechFix.API.Profiles
{
    public class UserProfile:Profile
    {
        public  UserProfile()
        {
            CreateMap<UserCreateDTO, User>();
            CreateMap<User, UserReadDTO>();
        }

    }
}

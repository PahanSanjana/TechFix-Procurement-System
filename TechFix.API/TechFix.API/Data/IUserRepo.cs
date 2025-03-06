using TechFix.API.Model;
namespace TechFix.API.Data
{
    public interface IUserRepo
    {
        bool Save();
        User GetUser(int id);
        bool UpdateUser(User user);
        bool DeleteUser(User user);
        bool CreateUser(User user);
        IEnumerable<User> GetUsers();
    }
}

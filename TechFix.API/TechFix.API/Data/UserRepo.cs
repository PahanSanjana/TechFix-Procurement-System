using TechFix.API.Model;

namespace TechFix.API.Data
{
    public class UserRepo: IUserRepo
    {
        private AppDBContext _dbContext;
        public UserRepo(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateUser(User user)
        {
            if (user != null)
            {
                _dbContext.Users.Add(user);
                return Save();
            }
            else
                return false;
        }

        public bool DeleteUser(User user)
        {
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                return Save();
            }
            else
                return false;
        }

        public User GetUser(int id)
        {
            return _dbContext.Users.FirstOrDefault(user => user.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public bool Save()
        {
            int count = _dbContext.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool UpdateUser(User user)
        {
            if (user != null)
            {
                _dbContext.Users.Update(user);
                return Save();
            }
            else
                return false;
        }
    }
}

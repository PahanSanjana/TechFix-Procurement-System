using TechFix.API.Model;

namespace TechFix.API.Data
{
    public class CustomerRepo : ICustomerRepo
    {
        private AppDBContext _dbContext;
        public CustomerRepo(AppDBContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        public bool CreateCustomer(Customer customer)
        {
            if (customer != null)
            {
                _dbContext.Customers.Add(customer);
                return Save();
            }
            else
                return false;
        }

        public bool DeleteCustomer(Customer customer)
        {
            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
                return Save();
            }
            else
                return false;
        }

        public  Customer GetCustomer(int id)
        {
            return _dbContext.Customers.FirstOrDefault(customer => customer.Id == id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public bool Save()
        {
            int count = _dbContext.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool UpdateCustomer(Customer customer)
        {
            if (customer != null)
            {
                _dbContext.Customers.Update(customer);
                return Save();
            }
            else
                return false;
        }
    }
}

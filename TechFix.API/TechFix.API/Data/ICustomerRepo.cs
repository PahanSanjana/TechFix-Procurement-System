using TechFix.API.Model;
namespace TechFix.API.Data
{
    public interface ICustomerRepo
    {
        bool Save();
        Customer GetCustomer(int id);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool CreateCustomer(Customer customer);
        IEnumerable<Customer> GetCustomers();
    }
}

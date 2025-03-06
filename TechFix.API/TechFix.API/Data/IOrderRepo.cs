using TechFix.API.Model;
namespace TechFix.API.Data
{
    public interface IOrderRepo
    {
        bool Save();
        Order GetOrder(int id);
        bool UpdateOrder(Order order);
        bool DeleteOrder(Order order);
        bool CreateOrder(Order order);
        IEnumerable<Order> GetOrders();
    }
}

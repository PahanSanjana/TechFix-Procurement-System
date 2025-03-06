using TechFix.API.Model;

namespace TechFix.API.Data
{
    public class OrderRepo : IOrderRepo
    {
       private AppDBContext _dbContext;
        public OrderRepo(AppDBContext dbContext)
        { 
            _dbContext = dbContext;
        }

        public bool CreateOrder(Order order)
        {
            if (order != null)
            {
                _dbContext.Orders.Add(order);
                return Save();
            }
            else
                return false;
        }

        public bool DeleteOrder(Order order)
        {
            if (order != null)
            {
                _dbContext.Orders.Remove(order);
                return Save();
            }
            else
                return false;
        }

        public Order GetOrder(int id)
        {
            return _dbContext.Orders.FirstOrDefault(order => order.Id == id);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _dbContext.Orders.ToList();
        }

        public bool Save()
        {
            int count = _dbContext.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool UpdateOrder(Order order)
        {
            if (order != null)
            {
                _dbContext.Orders.Update(order);
                return Save();
            }
            else
                return false;
        }
    }
}

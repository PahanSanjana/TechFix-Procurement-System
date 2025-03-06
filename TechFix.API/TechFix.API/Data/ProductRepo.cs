using TechFix.API.Model;

namespace TechFix.API.Data
{
    public class ProductRepo: IProductRepo
    {
        private AppDBContext _dbContext;
        public ProductRepo(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateProduct(Product product)
        {
            if (product != null)
            {
                _dbContext.Products.Add(product);
                return Save();
            }
            else
                return false;
        }

        public bool DeleteProduct(Product product)
        {
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                return Save();
            }
            else
                return false;
        }

        public Product GetProduct(int code)
        {
            return _dbContext.Products.FirstOrDefault(product => product.Code == code);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public bool Save()
        {
            int count= _dbContext.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool UpdateProduct(Product product)
        {
            if (product != null)
            {
                _dbContext.Products.Update(product);
                return Save();
            }
            else
                return false;
        }
    }
}

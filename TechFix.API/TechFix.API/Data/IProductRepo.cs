using TechFix.API.Model;
namespace TechFix.API.Data
{
    public interface IProductRepo
    {
        bool Save();
        Product GetProduct(int code);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Product product);
        bool CreateProduct(Product product);
        IEnumerable<Product> GetProducts();
    }
}

using TechFix.API.Model;
namespace TechFix.API.Data
{
    public interface ISaleRepo
    {
        bool Save();
        Sale GetSale(int id);
        bool UpdateSale(Sale sale);
        bool DeleteSale(Sale sale);
        bool CreateSale(Sale sale);
        IEnumerable<Sale> GetSales();
    }
}

using TechFix.API.Model;

namespace TechFix.API.Data
{
    public class SaleRepo: ISaleRepo
    {
        private AppDBContext _dbContext;
        public SaleRepo(AppDBContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        public bool CreateSale(Sale sale)
        {
            if (sale != null)
            {
                _dbContext.Sales.Add(sale);
                return Save();
            }
            else
                return false;
        }

        public bool DeleteSale(Sale sale)
        {
            if (sale != null)
            {
                _dbContext.Sales.Remove(sale);
                return Save();
            }
            else
                return false;
        }

        public Sale GetSale(int id)
        {
            return _dbContext.Sales.FirstOrDefault(sale => sale.Id == id);
        }

        public IEnumerable<Sale> GetSales()
        {
            return _dbContext.Sales.ToList();
        }

        public bool Save()
        {
            int count = _dbContext.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool UpdateSale(Sale sale)
        {
            if (sale != null)
            {
                _dbContext.Sales.Update(sale);
                return Save();
            }
            else
                return false;
        }
    }
}

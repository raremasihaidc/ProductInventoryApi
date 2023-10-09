using ProductsInventory.Model;

namespace ProductsInventory.Repositories.Interface
{
    public interface IProductReportRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}

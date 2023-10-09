using ProductsInventory.Model;

namespace ProductsInventory.Handlers.Interface
{
    public interface IProductReportHandler
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}

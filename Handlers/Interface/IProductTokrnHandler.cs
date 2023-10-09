using ProductsInventory.Model;

namespace ProductsInventory.Handlers.Interface
{
    public interface IProductTokrnHandler
    {
        void Add(Product product);
        List<Product> GetAll();
        Product GetById(int id);
    }
}

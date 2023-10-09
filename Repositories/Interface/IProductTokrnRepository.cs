using ProductsInventory.Model;

namespace ProductsInventory.Repositories.Interface
{
    public interface IProductTokrnRepository
    {
        void Add(Product product);
        List<Product> GetAll();
        Product GetById(int id);
    }
}

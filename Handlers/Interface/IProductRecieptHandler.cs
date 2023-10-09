using ProductsInventory.Model;

namespace ProductsInventory.Handlers.Interface
{
    public interface IProductRecieptHandler
    {
        void Update(Product product);
        List<Product> GetAll();
        Product GetById(int id);
    }
}

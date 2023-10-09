using ProductsInventory.Model;

namespace ProductsInventory.Handlers.Interface
{
    public interface IProuductVoucherHandler
    {
        void Update(Product product);
        List<Product> GetAll();
        Product GetById(int id);
    }
}

using ProductsInventory.Model;

namespace ProductsInventory.Repositories.Interface
{
    public interface IProductRecieptRepository
    {
        void Update(Product product);
        List<Product> GetAll();
        Product GetById(int id);
    }
}

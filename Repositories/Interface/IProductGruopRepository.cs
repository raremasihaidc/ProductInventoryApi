using ProductsInventory.Model;

namespace ProductsInventory.Repositories.Interface
{
    public interface IProductGruopRepository
    {
         void Add( Product product);
         void Update( Product product);
         void Delete( Product product);
         List<Product> GetAll();
         Product GetById(int id);
    }
}

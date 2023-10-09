using AutoMapper;
using ProductsInventory.Data;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMapper _mapper;
        private readonly ProductDbContext _dbContext;
        ProductRepository(IMapper mapper, ProductDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Add(Product product)
        {
            _dbContext.Products.Add(product);
        }

        public void Delete(Product product)
        {
            _dbContext.Products.Remove(product);
        }

        public List<Product> GetAll()
        {
           return _dbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            var getProductRepository=_dbContext.Products.Find(id);
            return getProductRepository;
        }

        public void Update(Product product)
        { _dbContext.Products.Update(product);
        }
    }
}

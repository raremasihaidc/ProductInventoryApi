using AutoMapper;
using ProductsInventory.Data;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Repositories
{
    public class ProductTokrnRepository : IProductTokrnRepository
    {
        private readonly IMapper _mapper;
        private readonly ProductDbContext _dbContext;
        ProductTokrnRepository(IMapper mapper, ProductDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Add(Product product)
        {
            _dbContext.Products.Add(product);   
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            var getProductToken = _dbContext.Products.Find(id);
            return getProductToken;
        }
    }
}

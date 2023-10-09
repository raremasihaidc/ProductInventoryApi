using AutoMapper;
using ProductsInventory.Data;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Repositories
{
    public class ProductRecieptRepository : IProductRecieptRepository
    {
        private readonly IMapper _mapper;
        private readonly ProductDbContext _dbContext;
         ProductRecieptRepository(IMapper mapper, ProductDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Update(Product product)
        {
           _dbContext.Products.Update(product);
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            var getProductReciept = _dbContext.Products.Find(id);
            return getProductReciept;
        }
    }
}

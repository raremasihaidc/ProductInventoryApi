using AutoMapper;
using ProductsInventory.Data;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Repositories
{
    public class ProuductVoucherRepository : IProuductVoucherRepository
    {
        private readonly IMapper _mapper;
        private readonly ProductDbContext _dbContext;
        ProuductVoucherRepository(IMapper mapper, ProductDbContext dbContext)
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
            var getProductVoucher = _dbContext.Products.Find(id);
            return getProductVoucher;
        }
    }
}

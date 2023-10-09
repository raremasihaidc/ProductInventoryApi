using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductsInventory.Data;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Repositories
{  
    public class ProductReportRepository : IProductReportRepository
    {
        private readonly IMapper _mapper;
        private readonly ProductDbContext _dbContext;
        ProductReportRepository(IMapper mapper, ProductDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            var getProductReportRepository = _dbContext.Products.Find(id);
            return getProductReportRepository;
        }
    }
}

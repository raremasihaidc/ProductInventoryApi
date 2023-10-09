using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductsInventory.Data;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Repositories
{
    public class ProductGruopRepository  :IProductGruopRepository
    {
        private readonly IMapper _mapper;
        private readonly ProductDbContext _dbContext;
        public ProductGruopRepository(IMapper mapper, ProductDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
         public void Add(Product product)
        {
            _dbContext.Products.Add( product );
        }

        public void Update(Product product)
        {
            _dbContext.Update( product );
        }

        public void Delete(Product product)
        {
            _dbContext.Remove( product );
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetById(int id)
        {      var getProductGruopbyid=_dbContext.Products.Find( id);
            return getProductGruopbyid;
        }
    }
}

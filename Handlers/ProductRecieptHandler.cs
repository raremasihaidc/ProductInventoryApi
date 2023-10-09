using AutoMapper;
using ProductsInventory.Data;
using ProductsInventory.Handlers.Interface;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Handlers
{
    public class ProductRecieptHandler : IProductRecieptHandler
    { private readonly ProductDbContext _productDbContext;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRecieptRepository _repository;
        private readonly IMapper _mapper;
        public ProductRecieptHandler(IProductRecieptRepository repository, IMapper mapper, IUnitOfWork unitOfWork,ProductDbContext productDbContext)
        {  _productDbContext = productDbContext;
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
        }
        public void Update(Product product)
        {
            var updateReciept =_productDbContext.Products.FirstOrDefault(x=>x.ProductId == product.ProductId);
            if (updateReciept != null)
            { var result=_mapper.Map<Product>(updateReciept);   
            }
            _repository.Update(product);
            _unitOfWork.Save();

        }

        public List<Product> GetAll()
        {
         var products = _repository.GetAll();
            var productReceipt=_mapper.Map<List<Product>>(products);
            return productReceipt;
        }

        public Product GetById(int id)
        {
            var result = _repository.GetById(id);
            return result;

        }
    }
}

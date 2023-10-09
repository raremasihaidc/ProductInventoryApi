using AutoMapper;
using ProductsInventory.Handlers.Interface;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Handlers
{
    public class ProductHandler : IProductHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductHandler(IProductRepository repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(Product product)
        {   var addproduct=_mapper.Map<Product>(product);
            _repository.Add(product);
            _unitOfWork.Save();
        }

        public void Delete(Product product)
        {
            var deleteProduct = _repository.GetById(product.ProductId);
            if (deleteProduct != null)
            {
                _repository.Delete(deleteProduct);
                _unitOfWork.Save();
            }
        }

        public List<Product> GetAll()
        {
            var list = _repository.GetAll();
            var getProduct = _mapper.Map<List<Product>>(list);
            return getProduct;
        }

        public Product GetById(int id)
        {
            var result = _repository.GetById(id);
            if (result != null)
            {
                _repository.Delete(result);
            }
            return result;
        }

        public void Update(Product product)
        {
            var model = _repository.GetById(product.ProductId);
            if (model != null)
            {
                var result = _mapper.Map<Product>(model);
                _unitOfWork.Save();
            }

        }
    }
}

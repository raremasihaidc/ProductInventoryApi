using AutoMapper;
using ProductsInventory.Handlers.Interface;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Handlers
{
    public class ProductReportHandler : IProductReportHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductReportRepository _repository;
        private readonly IMapper _mapper;
        public ProductReportHandler(IProductReportRepository repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
        }
        public List<Product> GetAll()
        {
            var products = _repository.GetAll();
            var productReceipt = _mapper.Map<List<Product>>(products);
            return productReceipt;
        }

        public Product GetById(int id)
        {

            var result = _repository.GetById(id);
            return result;
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.OutputCaching;
using ProductsInventory.Data;
using ProductsInventory.Handlers.Interface;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Handlers
{
    public class ProuductVoucherHandler : IProuductVoucherHandler
    {
        private readonly ProductDbContext _productDbContext;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProuductVoucherHandler _repository;
        private readonly IMapper _mapper;
        public ProuductVoucherHandler( IProuductVoucherHandler repository, IMapper mapper ,IUnitOfWork unitOfWork, ProductDbContext productDbContext)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
        }
        public void Update(Product product)
        {
            var updateReciept = _productDbContext.Products.FirstOrDefault(x => x.ProductId == product.ProductId);
            if (updateReciept != null)
            {
                var result = _mapper.Map<Product>(updateReciept);
            }
            _repository.Update(product);
            _unitOfWork.Save();
        }

        public List<Product> GetAll()
        {
            var list = _repository.GetAll();
            var getList=_mapper.Map< List<Product>>(list);
            return getList;
        }

        public Product GetById(int id)
        {
           var model=_repository.GetById(id);
            return model;
        }
    }
}

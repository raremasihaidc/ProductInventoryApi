using AutoMapper;
using ProductsInventory.Handlers.Interface;
using ProductsInventory.Model;
using ProductsInventory.Repositories.Interface;

namespace ProductsInventory.Handlers
{
    public class ProductGruopHandler : IProductGruopHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductGruopHandler _repository;
        private readonly IMapper _mapper;
        public ProductGruopHandler(ProductGruopHandler repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
        }
        public void Add(Product product)
        {
            _repository.Add(product);
            _unitOfWork.Save(); 
        }

        public void Delete(Product product)
        {
            var deletemodel = _repository.GetById(product.ProductId);
            if(deletemodel != null)
            {
                _repository.Delete(deletemodel);
                _unitOfWork.Save();
            } 
        }

        public List<Product> GetAll()
        {
            var list = _repository.GetAll();
      
            return list;
            
        }

        public Product GetById(int id)
        {
           var result=_repository.GetById(id);
            if( result!=null)
            {
                _repository.Delete(result);
            } 
            return result;
        }

        public void Update(Product product)
        {
            var model=_repository.GetById(product.ProductId);
            if (model != null)
            {
                var result=_mapper.Map<Product>(model);
                _unitOfWork.Save();
            }
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductsInventory.DTOS;
using ProductsInventory.Handlers.Interface;

namespace ProductsInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductGroupController : Controller
    {
        private readonly IProductGruopHandler _productGroupHandler;
        private readonly IMapper _mapper;
        public ProductGroupController(IProductGruopHandler productGroupHandler, IMapper mapper)
        {
            _productGroupHandler = productGroupHandler;
            _mapper = mapper;
        }
        [HttpGet] public  IActionResult  Get() => Ok(_productGroupHandler.GetAll());

        [HttpPost]
        public IActionResult AddProduct(ProductGruopDTOS productGruopDTO)
        {
            var addProduct = _mapper.Map<ProductDTOS>(productGruopDTO);
            if (addProduct == null)
            {
                return BadRequest("null ");
            }
            _productGroupHandler.Add(addProduct);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateProduct(ProductGruopDTOS productGruopDTO)
        {
            var updateProduct = _mapper.Map<ProductDTOS>(productGruopDTO);
            _productGroupHandler.Update(updateProduct);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var deleteProduct = _productGroupHandler.GetById(id);
            _productGroupHandler.Delete(deleteProduct);
            return Ok();

        }
    }
}

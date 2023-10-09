using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductsInventory.DTOS;
using ProductsInventory.Handlers.Interface;

namespace ProductsInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       private readonly IProductHandler _productHandler;
       private readonly IMapper _mapper;
        public ProductController(IProductHandler productHandler, IMapper mapper)
        {
            _productHandler = productHandler;
            _mapper = mapper;
        }

        [HttpGet] public IActionResult Get()=>Ok(_productHandler.GetAll());

        [HttpPost]
        public IActionResult AddProduct(ProductDTOS productDTO)
        {
            var addProduct=_mapper.Map<ProductDTOS>(productDTO);
            if (addProduct == null)
            {
                return BadRequest("null ");
            }
           _productHandler.Add(addProduct);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateProduct(ProductDTOS productDTO)
        {
            var updateProduct = _mapper.Map<ProductDTOS>(productDTO);
            _productHandler.Update(updateProduct);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        { var deleteProduct=_productHandler.GetById(id);
            _productHandler.Delete(deleteProduct);
            return Ok();

        }
    }
}

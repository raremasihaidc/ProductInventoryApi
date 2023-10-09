using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductsInventory.DTOS;
using ProductsInventory.Handlers;
using ProductsInventory.Handlers.Interface;

namespace ProductsInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecieptController : Controller
    {
        private readonly IProductRecieptHandler _productRecieptHandler;
        private readonly IMapper _mapper;
        public RecieptController(IProductRecieptHandler productRecieptHandler, IMapper mapper)
        {
            _productRecieptHandler = productRecieptHandler;
            _mapper = mapper;
        }

        [HttpGet] public IActionResult Get() => Ok(_productRecieptHandler.GetAll());

        [HttpPut]
        public IActionResult UpdateProduct(ProductGruopDTOS productGruopDTO)
        {
            var updateProduct = _mapper.Map<ProductDTOS>(productGruopDTO);
            _productRecieptHandler.Update(updateProduct);
            return Ok();
        }
    }
}

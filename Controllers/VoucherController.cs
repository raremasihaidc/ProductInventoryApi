using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductsInventory.DTOS;
using ProductsInventory.Handlers.Interface;

namespace ProductsInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : Controller
    {
        private readonly IProuductVoucherHandler _productVoucherHandler;
        private readonly IMapper _mapper;
        public VoucherController(IProuductVoucherHandler productVoucherHandler, IMapper mapper)
        {
            _productVoucherHandler = productVoucherHandler;
            _mapper = mapper;
        }

        [HttpGet] public IActionResult Get() => Ok(_productVoucherHandler.GetAll());

        [HttpPut]
        public IActionResult UpdateProduct(ProductGruopDTOS productGruopDTO)
        {
            var updateProduct = _mapper.Map<ProductDTOS>(productGruopDTO);
            _productVoucherHandler.Update(updateProduct);
            return Ok();
        }
    }
}

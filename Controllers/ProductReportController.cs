using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductsInventory.DTOS;
using ProductsInventory.Handlers.Interface;

namespace ProductsInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductReportController : Controller
    {
        private readonly IProductReportHandler _productReportHandler;
        private readonly IMapper _mapper;
        public ProductReportController(IProductReportHandler productReportHandler, IMapper mapper)
        {
            _productReportHandler = productReportHandler;
            _mapper = mapper;
        }
        [HttpGet] public IActionResult Get() => Ok(_productReportHandler.GetAll());

    }
}

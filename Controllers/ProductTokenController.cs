using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ProductsInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductTokenController : Controller
    {
        private readonly IMapper _mapper;
        public ProductTokenController(IMapper mapper)
        {
            _mapper = mapper;
        }
        
    }
}

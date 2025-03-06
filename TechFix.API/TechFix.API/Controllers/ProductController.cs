using TechFix.API.Model;
using TechFix.API.DTO;
using AutoMapper;
using TechFix.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace TechFix.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductRepo _productRepo;
        public ProductController(IProductRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _productRepo = repo;
        }

        [HttpPost]
        public ActionResult CreateProduct(ProductCreateDTO createDTO)
        {
            var product = _mapper.Map<Product>(createDTO);
            if (_productRepo.CreateProduct(product))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = _productRepo.GetProducts();
            return Ok(_mapper.Map<IEnumerable<ProductReadDTO>>(products));
        }

        [HttpGet("code",Name ="GetByCode")]
        public ActionResult<ProductReadDTO> GetProduct(int code )
        { 
            var product = _productRepo.GetProduct(code);
            if (product != null)
                return Ok(_mapper.Map<ProductReadDTO>(product));
            else
                return NotFound();
        }

        [HttpDelete("{code}")]
        public ActionResult DeleteProduct(int code)
        {
            var product = _productRepo.GetProduct(code);
            if (product != null)
            {
                _productRepo.DeleteProduct(product);
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpPut]
        public ActionResult UpdateProduct(ProductCreateDTO createDTO)
        {
            var product = _mapper.Map<Product>(createDTO);
            if (_productRepo.UpdateProduct(product))
            {
                return Ok();
            }
            else
                return NotFound();
        }
    }
}

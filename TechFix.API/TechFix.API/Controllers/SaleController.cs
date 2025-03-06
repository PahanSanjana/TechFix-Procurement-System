using TechFix.API.Model;
using TechFix.API.DTO;
using AutoMapper;
using TechFix.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace TechFix.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : Controller
    {
        private readonly IMapper _mapper;
        public readonly ISaleRepo _saleRepo;

        public SaleController(ISaleRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _saleRepo = repo;
        }

        [HttpPost]
        public ActionResult CreateSale(SaleCreateDTO createDTO)
        {
            var sale = _mapper.Map<Sale>(createDTO);
            if (_saleRepo.CreateSale(sale))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sale>> GetSales()
        {
            var sales = _saleRepo.GetSales();
            return Ok(_mapper.Map<IEnumerable<SaleReadDTO>>(sales));
        }

        [HttpGet("id", Name = "GetSaleById")]
        public ActionResult<SaleReadDTO> GetSale(int id)
        {
            var sale = _saleRepo.GetSale(id);
            if (sale != null)
                return Ok(_mapper.Map<SaleReadDTO>(sale));
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteSale(int id)
        {
            var sale = _saleRepo.GetSale(id);
            if (sale != null)
            {
                _saleRepo.DeleteSale(sale);
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpPut]
        public ActionResult UpdateSale(SaleCreateDTO createDTO)
        {
            var sale = _mapper.Map<Sale>(createDTO);
            if (_saleRepo.UpdateSale(sale))
            {
                return Ok();
            }
            else
                return NotFound();
        }
    }
}

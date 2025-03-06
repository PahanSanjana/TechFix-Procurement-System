using TechFix.API.Model;
using TechFix.API.DTO;
using TechFix.API.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace TechFix.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepo _customerRepo;

        public CustomerController(ICustomerRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepo = repo;
        }

        [HttpPost]
        public ActionResult CreateCustomer(CustomerCreateDTO createDTO)
        {
            var customer = _mapper.Map<Customer>(createDTO);
            if (_customerRepo.CreateCustomer(customer))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            var customers = _customerRepo.GetCustomers();
            return Ok(_mapper.Map<IEnumerable<CustomerReadDTO>>(customers));
        }

        [HttpGet("id", Name = "GetCustomerById")]
        public ActionResult<CustomerReadDTO> GetCustomer(int id)
        {
            var customer = _customerRepo.GetCustomer(id);
            if (customer != null)
                return Ok(_mapper.Map<CustomerReadDTO>(customer));
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            var customer = _customerRepo.GetCustomer(id);
            if (customer != null)
            {
                _customerRepo.DeleteCustomer(customer);
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpPut]
        public ActionResult UpdateCustomer(CustomerCreateDTO createDTO)
        {
            var customer = _mapper.Map<Customer>(createDTO);
            if (_customerRepo.UpdateCustomer(customer))
            {
                return Ok();
            }
            else
                return NotFound();
        }
    }
}

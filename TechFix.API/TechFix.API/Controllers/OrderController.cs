using TechFix.API.Model;
using TechFix.API.DTO;
using TechFix.API.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace TechFix.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepo _orderRepo;

        public OrderController(IOrderRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _orderRepo = repo;
        }

        [HttpPost]
        public ActionResult CreateOrder(OrderCreateDTO createDTO)
        {
            var order = _mapper.Map<Order>(createDTO);
            if (_orderRepo.CreateOrder(order))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            var orders = _orderRepo.GetOrders();
            return Ok(_mapper.Map<IEnumerable<OrderReadDTO>>(orders));
        }

        [HttpGet("id", Name = "GetOrderById")]
        public ActionResult<OrderReadDTO> GetOrder(int id)
        {
            var order = _orderRepo.GetOrder(id);
            if (order != null)
                return Ok(_mapper.Map<OrderReadDTO>(order));
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var order = _orderRepo.GetOrder(id);
            if (order != null)
            {
                _orderRepo.DeleteOrder(order);
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpPut]
        public ActionResult UpdateOrder(OrderCreateDTO createDTO)
        {
            var order = _mapper.Map<Order>(createDTO);
            if (_orderRepo.UpdateOrder(order))
            {
                return Ok();
            }
            else
                return NotFound();
        }
    }
}

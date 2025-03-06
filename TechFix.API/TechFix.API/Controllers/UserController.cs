using TechFix.API.Model;
using TechFix.API.DTO;
using TechFix.API.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace TechFix.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _userRepo = repo;
        }
        [HttpPost]
        public ActionResult CreateUser(UserCreateDTO createDTO)
        {
            var user = _mapper.Map<User>(createDTO);
            if (_userRepo.CreateUser(user))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var user = _userRepo.GetUsers();
            return Ok(_mapper.Map<IEnumerable<UserReadDTO>>(user));
        }

        [HttpGet("id", Name = "GetUserById")]
        public ActionResult<UserReadDTO> GetUser(int id)
        {
            var user = _userRepo.GetUser(id);
            if (user != null)
                return Ok(_mapper.Map<UserReadDTO>(user));
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var user = _userRepo.GetUser(id);
            if (user != null)
            {
                _userRepo.DeleteUser(user);
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpPut]
        public ActionResult UpdateUser(UserCreateDTO createDTO)
        {
            var user = _mapper.Map<User>(createDTO);
            if (_userRepo.UpdateUser(user))
            {
                return Ok();
            }
            else
                return NotFound();
        }
    }
}

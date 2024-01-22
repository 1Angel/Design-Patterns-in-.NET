using Microsoft.AspNetCore.Mvc;
using Unit_Of_Work_in_Repository_Pattern.Models;
using Unit_Of_Work_in_Repository_Pattern.Repositories;
using Unit_Of_Work_in_Repository_Pattern.UnitOfWork;

namespace Unit_Of_Work_in_Repository_Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpPost("create")]
        public ActionResult Create(User user)
        {
            _unitOfWork.UserRepository.Save(user);
            _unitOfWork.Save();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var users = await _unitOfWork.UserRepository.Get();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById([FromRoute] int id)
        {
            var userId = await _unitOfWork.UserRepository.GetById(id);
            return Ok(userId);
        }
    }
}

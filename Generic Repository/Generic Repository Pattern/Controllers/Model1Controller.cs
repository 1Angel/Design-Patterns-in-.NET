using Generic_Repository_Pattern.Models;
using Generic_Repository_Pattern.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Generic_Repository_Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Model1Controller: ControllerBase
    {
        private readonly IRepository<Model1> _repository;
        public Model1Controller(IRepository<Model1> repository)
        {
            _repository = repository;
        }

        [HttpPost("create")]
        public ActionResult Create([FromBody] Model1 Data)
        {
            var save =  _repository.Save(Data);
            if (save != null)
            {
                return Ok(save);
            }
            else { return BadRequest(); }   
        }

        [HttpGet]
        public ActionResult Get()
        {
            var list = _repository.Get();
            if(list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }

        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            var byId = _repository.GetById(id);
            if(byId == null)
            {
                return NotFound(id);
            }
            return Ok(byId);
        }
    }
}

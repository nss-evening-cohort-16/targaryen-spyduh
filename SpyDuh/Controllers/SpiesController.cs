using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpyDuh.DataAccess;
using SpyDuh.Models;

namespace SpyDuh.Controllers
{
    [Route("api/spies")]
    [ApiController]
    public class SpiesController : ControllerBase
    {
        SpyRepository _repo = new SpyRepository();

        [HttpGet]
        public List<Spy> GetAllSpies()
        {
            return _repo.GetAll();
        }

        [HttpGet("name/{name}")]
        public IActionResult GetSpyByName(string name)
        {
            var match = _repo.GetByName(name);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
        [HttpGet("skill/{skill}")]
        public IActionResult GetSpyBySkill(string skill)
        {
            var match = _repo.GetBySkill(skill);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

        [HttpGet("relationship/{enemy}")]
        public IActionResult GetSpyEnemies()
        {
            var match = _repo.GetEnemies();
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
    }
}

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
        SpiesRepository _spies = new SpiesRepository();

        [HttpGet]
        public List<Spy> GetAllSpies()
        {
            return _spies.GetAll();
        }

        [HttpGet("name/{name}")]
        public IActionResult GetSpyByName(string name)
        {
            var match = _spies.GetSpyByName(name);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
    }
}

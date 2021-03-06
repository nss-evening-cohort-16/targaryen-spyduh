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
        SpyRepository _spyRepo = new SpyRepository();

        [HttpGet]
        public List<Spy> GetAllSpies()
        {
            return _spyRepo.GetAll();
        }

        [HttpGet("name/{name}")]
        public IActionResult GetSpyByName(string name)
        {
            var match = _spyRepo.GetByName(name);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
        [HttpGet("skill/{skill}")]
        public IActionResult GetSpyBySkill(string skill)
        {
            var match = _spyRepo.GetBySkill(skill);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

        [HttpGet("relationship/{spyRelationship}")]

        public IActionResult GetRelationshipByType(SpyRelationship spyRelationship)
        {
            var matches = _spyRepo.GetRelationshipType(spyRelationship);
            if (matches != null)
            {
                return Ok(matches);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{name}/{spyRelationship}")]

        public IActionResult GetFriendOfFriend(string name, SpyRelationship spyRelationship)
        {
            var matches = _spyRepo.GetFriendsOfFriends(name, spyRelationship);
            if (matches != null)
            {
                return Ok(matches);
            }
            else
            {
                return NotFound();
            }
            return Ok(matches);
        }
        

        [HttpPost]
        public IActionResult Post(Spy newSpy)
        {
            if (!ValidNewSpy(newSpy))
            {
                return BadRequest(newSpy);
            }
            else
            {
                _spyRepo.Post(newSpy);
                return Ok(newSpy);
            }
        }

        private bool ValidNewSpy(Spy newSpy)
        {
            if (newSpy == null)
            {
                return false;
            }
            if (newSpy.CodeName == null)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(newSpy.CodeName))
            {
                return false;
            }
            if (newSpy.SkillsAndServices == null)
            {
                return false;
            }
            if (newSpy.OriginStory == null)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(newSpy.OriginStory))
            {
                return false;
            }

            return true;
        }

        [HttpGet("profile/{profile}")]
        public IActionResult GetProfile(string profile)
        {
            var match = _spyRepo.GetProfile(profile);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateSpy(int id, Spy spy)
        {
            if (id != spy.Id)
            {
                return BadRequest();
            }

            var existingSpy = _spyRepo.GetById(id);
            if (existingSpy == null)
            {
                return NotFound();
            }
            else
            {
                _spyRepo.Update(spy);
                return NoContent();
            }
        }

        [HttpDelete("name/{name}")]
        public IActionResult DeleteASpy(string name)
        {
            var matchingSpy = _spyRepo.GetByName(name);
            if (matchingSpy == null)
            {
                return NotFound();
            }
            else
            {
                _spyRepo.DeleteSpy((Spy)matchingSpy);
                return NoContent();
            }
        }
    }
}

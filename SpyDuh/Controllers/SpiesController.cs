﻿using Microsoft.AspNetCore.Http;
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
        public List<Spies> GetAllSpies()
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
    }
}

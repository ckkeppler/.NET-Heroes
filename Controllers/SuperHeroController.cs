using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var result = _superHeroService.GetAllHeroes();
            if (result?.Count == 0)
                return NotFound("No heroes found.");

            return Ok(result);

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SuperHero>> GetSuperHeroById(int id)
        {
            var result = _superHeroService.GetSuperHeroById(id);
            if (result == null)
                return NotFound("Hero not found.");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddSuperHero(SuperHero hero)
        {
            var result = _superHeroService.AddSuperHero(hero);

            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<SuperHero>> UpdateHeroById(int id, SuperHero request)
        {
            var result = _superHeroService.UpdateHeroById(id, request);
            if (result == null)
                return NotFound("Hero not found.");

            return Ok(result);

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<SuperHero>> DeleteHeroById(int id)
        {
            var result = _superHeroService.DeleteHeroById(id);
            if (result == null)
            {
                return NotFound("Hero not found.");
            }

            return Ok(result);
        }
    }
}


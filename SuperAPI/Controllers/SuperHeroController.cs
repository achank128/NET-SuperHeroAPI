using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperAPI.Data;
using SuperAPI.Models;
using SuperHeroAPI.Dto;
using SuperHeroAPI.Services.SuperHeroService;

namespace SuperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
		private readonly IMapper _mapper;

		public SuperHeroController(ISuperHeroService superHeroService, IMapper mapper)
        {
            _superHeroService = superHeroService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            var superhero = await _superHeroService.GetAllHero();
            return Ok(_mapper.Map<List<SuperHeroDto>>(superhero));
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetbyId(int id)
        {
            var hero = await _superHeroService.GetHeroById(id);
            if (hero == null)
                return BadRequest("Not found hero!");
            return Ok(_mapper.Map<SuperHeroDto>(hero));
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> Create(SuperHero h)
        {
           var heros = await _superHeroService.CreateHero(h);
           return Ok(_mapper.Map<List<SuperHeroDto>>(heros));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> Update(int id, SuperHero req)
        {
            var heros = await _superHeroService.UpdateHero(id, req);
            if (heros == null)
                return BadRequest("Not found hero!");
            return Ok(_mapper.Map<List<SuperHeroDto>>(heros));
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> Delete(int id)
        {
            var heros = await _superHeroService.DeleteHero(id);
            if (heros == null)
                return BadRequest("Not found hero!");
            return Ok(_mapper.Map<List<SuperHeroDto>>(heros));
        }
    }
}

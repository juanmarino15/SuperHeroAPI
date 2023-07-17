
using API.Models;
using API.Services.SuperHeroService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly iSuperHeroService _superHeroService;
       
      public SuperHeroController(iSuperHeroService superHeroService)
      {
            _superHeroService = superHeroService;
        
      }
//getting all heroes
       [HttpGet]
       public async Task<ActionResult<List<SuperHero>>> GetAllHeroes() 
       {
        var result = _superHeroService.GetAllHeroes();
        return Ok(result);
       }

//getting hero by id
       [HttpGet] //could also do [HttpGet("{id}")]
       [Route("{id}")] //get parameter by id
       public async Task<ActionResult<SuperHero>> GetSingleHeroe(int id) 
       {
        var result = _superHeroService.GetSingleHero(id);
        if(result == null)
            return NotFound("Sorry, but this hero doesn't exist");
        return Ok(result);
       }

       //adding a hero 
       [HttpPost]
       public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)  //of type SuperHero name hero. passed through the body
       {
            var result = _superHeroService.AddHero(hero);
            return Ok(result);
       }


        //update record
        [HttpPut ("{id}")] //get parameter by id
       public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request) 
       {
        var result = _superHeroService.UpdateHero(id, request);
        if(result == null)
            return NotFound("Hero not Found.");
        return Ok(result);
       }

        //delete record
        [HttpDelete ("{id}")] //get parameter by id
       public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id) 
       {
        var result = _superHeroService.DeleteHero(id);
        if(result == null)
            return NotFound("Hero not Found.");
        return Ok(result);
       }


    }
}
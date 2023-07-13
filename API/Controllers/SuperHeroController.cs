
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : Controller
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>{
            new SuperHero{ 
                Id =1, 
                Name = "Spider Man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York City"
                },
            new SuperHero{ 
                Id =2, 
                Name = "Iron Man",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "Malibu"
                }
        };

//getting all heroes
       [HttpGet]
       public async Task<ActionResult<List<SuperHero>>> GetAllHeores() 
       {
        return Ok(superHeroes);
       }

//getting hero by id
       [HttpGet] //could also do [HttpGet("{id}")]
       [Route("{id}")] //get parameter by id
       public async Task<ActionResult<SuperHero>> GetSingleHeroe(int id) 
       {
        var hero = superHeroes.Find(x => x.Id == id);
        if(hero == null)
            return NotFound("Sorry, but this hero doesn't exist");
        return Ok(hero);
       }

       //adding a hero 
       [HttpPost]
       public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)  //of type SuperHero name hero. passed through the body
       {
        superHeroes.Add(hero); //using the class to add a new hero
        return Ok(superHeroes);
       }

    }
}
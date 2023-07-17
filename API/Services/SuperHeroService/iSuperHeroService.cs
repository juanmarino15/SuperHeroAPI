namespace API.Services.SuperHeroService
{
    public interface iSuperHeroService
    {
        List<SuperHero> GetAllHeroes();
        SuperHero GetSingleHero(int id);
        List<SuperHero> AddHero(SuperHero hero);
        List<SuperHero>?UpdateHero(int id, SuperHero hero);
        List<SuperHero>?DeleteHero(int id); 

    }
}
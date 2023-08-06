using SuperAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetAllHero();
        Task<SuperHero?> GetHeroById(int id);
        Task<List<SuperHero>> CreateHero(SuperHero hero);
        Task<List<SuperHero>> UpdateHero(int id, SuperHero req);
        Task<List<SuperHero>> DeleteHero(int id);
    }
}

using Microsoft.EntityFrameworkCore;
using SuperAPI.Data;
using SuperAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        //private static List<SuperHero> heroes = new List<SuperHero>
        //{
        //    new SuperHero {
        //        Id = 1,
        //        Name = "Spider Man",
        //        FirstName = "Peter",
        //        LastName = "Packer",
        //        Place = "New York City"
        //    },
        //    new SuperHero {
        //        Id = 2,
        //        Name = "Iron Man",
        //        FirstName = "Tony",
        //        LastName = "Stark",
        //        Place = "New York City"
        //    },
        //    new SuperHero {
        //        Id = 3,
        //        Name = "Captain America",
        //        FirstName = "Steven",
        //        LastName = "Rogers",
        //        Place = "Avenger"
        //    },new SuperHero {
        //        Id = 4,
        //        Name = "Doctor Strange",
        //        FirstName = "Stephen",
        //        LastName = "Strange",
        //        Place = "Sanctum Sanctorum"
        //    },
        //};

        private readonly ApplicationDbContext _context;

        public SuperHeroService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SuperHero>> GetAllHero()
        {
            return await _context.SuperHero.ToListAsync();
        }

        public async Task<SuperHero?> GetHeroById(int id)
        {
            SuperHero hero = await _context.SuperHero.FindAsync(id);
            if (hero == null)
                return null;
            return hero;
        }

        public async Task<List<SuperHero>> CreateHero(SuperHero hero)
        {
            _context.SuperHero.Add(hero);
            await _context.SaveChangesAsync();

            return await _context.SuperHero.ToListAsync();
        }

        public async Task<List<SuperHero>> DeleteHero(int id)
        {
            SuperHero hero = await _context.SuperHero.FindAsync(id);
            if (hero == null)
                return null;
            _context.SuperHero.Remove(hero);
            await _context.SaveChangesAsync();
            return await _context.SuperHero.ToListAsync();
        }

        public async Task<List<SuperHero>> UpdateHero(int id, SuperHero req)
        {
            SuperHero hero = await _context.SuperHero.FindAsync(id);
            if (hero == null)
                return null;
            hero.Name = req.Name;
            hero.FirstName = req.FirstName;
            hero.LastName = req.LastName;
            hero.Place = req.Place;
            await _context.SaveChangesAsync();

            return await _context.SuperHero.ToListAsync();


        }
    }
}

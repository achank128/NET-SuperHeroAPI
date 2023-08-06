using Microsoft.EntityFrameworkCore;
using SuperAPI.Models;
using SuperHeroAPI.Models;

namespace SuperAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        #region DbSet       
        public DbSet<SuperHero> SuperHero { get; set; } 

        public DbSet<User> Users { get; set; }
        #endregion


    }
}

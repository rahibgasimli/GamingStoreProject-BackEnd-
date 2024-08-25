using GamingStoreTekrar.Entities;
using GamingStoreTekrar.Extentions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamingStoreTekrar.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GameTag> GameTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasIndex(g => g.Name)
                .IsUnique(true);

            //modelBuilder.SeedGames();
            //modelBuilder.SeedGenres();
            //modelBuilder.SeedTags();

            modelBuilder.SeedRoles();


            base.OnModelCreating(modelBuilder);
        }
    }
}

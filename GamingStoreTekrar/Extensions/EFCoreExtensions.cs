using GamingStoreTekrar.Entities;
using GamingStoreTekrar.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GamingStoreTekrar.Extentions
{
    public static class EFCoreExtensions
    {
        public static void SeedGames(this ModelBuilder builder)
        {
            List<Game> seedData = new List<Game>()
            {
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Call of Duty",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Impedit minus corrupti voluptate repudiandae assumenda illo consequuntur, quaerat animi. Quisquam, praesentium.",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/cta-bg.jpg",
                    Price = 60,
                    CreatedDate = DateTime.Now
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Assassin's Creed",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas aliquam aspernatur repellendus a, possimus vero at molestias voluptatibus maxime nisi!",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-01.jpg",
                    Price = 50,
                    CreatedDate = DateTime.Now
                },
                // Add more entries as needed...
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Halo Infinite",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cupiditate quibusdam eveniet voluptatum maiores expedita eos dolore itaque, doloremque ab quae.",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-02.jpg",
                    Price = 70,
                    CreatedDate = DateTime.Now
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "The Witcher 3: Wild Hunt",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint aliquid ab esse expedita veritatis eius quia repellendus, ipsam neque odit.",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-03.jpg",
                    Price = 40,
                    CreatedDate = DateTime.Now
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Red Dead Redemption 2",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque, quam exercitationem! Deserunt, obcaecati. Eaque minima tempora velit laudantium.",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-04.jpg",
                    Price = 55,
                    CreatedDate = DateTime.Now
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "FIFA 22",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequuntur quam deleniti doloribus recusandae sequi, laudantium doloremque quod sit omnis.",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-05.jpg",
                    Price = 45,
                    CreatedDate = DateTime.Now
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Minecraft",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatem iusto sit quae. Nesciunt, veniam dolorum! Ad, saepe. At, ipsum.",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-06.jpg",
                    Price = 30,
                    CreatedDate = DateTime.Now
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Cyberpunk 2077",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Autem quis iusto, blanditiis fugit dolorem odit nisi laborum sapiente eius!",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-05.jpg",
                    Price = 50,
                    CreatedDate = DateTime.Now
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "The Last of Us Part II",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat quaerat molestiae laborum corporis, laudantium odit voluptate eligendi tempore vero!",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-03.jpg",
                    Price = 45,
                    CreatedDate = DateTime.Now
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Grand Theft Auto V",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam nihil odio quos doloribus maiores, laborum minus, quibusdam distinctio consequatur!",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-02.jpg",
                    Price = 40,
                    CreatedDate = DateTime.Now
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Fortnite",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci voluptas exercitationem reiciendis iure eius dolorem excepturi molestias dolorum voluptatibus.",
                    ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
                    PhotoPath = "images/top-game-04.jpg",
                    Price = 0, // Free-to-play
                    CreatedDate = DateTime.Now
                },
            };

            builder.Entity<Game>()
                .HasData(seedData);
        }


        public static void SeedGenres(this ModelBuilder builder)
        {

            List<Genre> seedData = new List<Genre>()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Action",
                    CreatedDate = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Horror",
                    CreatedDate = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Adventure",
                    CreatedDate = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Simulation",
                    CreatedDate = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Battle royale",
                    CreatedDate = DateTime.Now
                },

            };

            builder.Entity<Genre>()
                .HasData(seedData);
        }

        public static void SeedTags(this ModelBuilder builder)
        {

            List<GameTag> seedData = new List<GameTag>()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "War",
                    CreatedDate = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Crafting",
                    CreatedDate = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Survival",
                    CreatedDate = DateTime.Now
                }

            };

            builder.Entity<GameTag>()
                .HasData(seedData);
        }

        public static void SeedRoles(this ModelBuilder builder)
        {
            var roles = Enum.GetNames(typeof(RoleTypes));
            var identityRoles = new List<IdentityRole>();

            foreach (var role in roles)
            {
                identityRoles.Add(new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = role,
                    NormalizedName = role.ToUpper(),
                });
            }

            builder.Entity<IdentityRole>()
                .HasData(identityRoles);
        }

    }
}

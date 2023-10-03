using game_spa.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace game_spa.Data
{
    public class DatabaseContext : IdentityDbContext<UserModel>
    {
        public DbSet<GameModel> Games { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
    }
}

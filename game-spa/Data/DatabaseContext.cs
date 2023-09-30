using game_spa.Models;
using Microsoft.EntityFrameworkCore;

namespace game_spa.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=JUPITER; Initial Catalog=GameSpaDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}

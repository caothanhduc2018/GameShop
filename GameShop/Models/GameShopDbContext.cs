using Microsoft.EntityFrameworkCore;
namespace GameShop.Models
{
    public class GameShopDbContext : DbContext
    {
        public GameShopDbContext(DbContextOptions<GameShopDbContext>
        options) : base(options) { }
        public DbSet<Game> Games { get; set; }
    }
}

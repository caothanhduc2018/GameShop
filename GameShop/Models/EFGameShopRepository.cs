using System.Linq;
namespace GameShop.Models
{
    public class EFGameShopRepository : IGameShopRepository
    {
        private GameShopDbContext context;
        public EFGameShopRepository(GameShopDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Game> Books => context.Games;

        public IQueryable<Game> Games => throw new NotImplementedException();
    }
}

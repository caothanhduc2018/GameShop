using System.Linq;
namespace GameShop.Models
{
    public interface IGameShopRepository
    {
        IQueryable<Game> Games { get; }
    }
}

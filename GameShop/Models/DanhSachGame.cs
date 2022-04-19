using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace GameShop.Models
{
    public class DanhSachGame
    {
        public List<Game>? Games { get; set; }
        public SelectList? Genres { get; set; }
        public string? GameGenre { get; set; }
        public string? PlayString { get; set; }
    }
}

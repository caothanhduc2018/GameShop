using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GameShop.Data;
using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
namespace GameShop.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameShopContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<GameShopContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.Game.Any())
                {
                    return; // Không thêm nếu cuốn sách đã tồn tại trong DB
                }
                context.Game.AddRange(
                new Game
                {
                    TenGame = "Dying Light 2",
                    NgayMua = DateTime.Parse("2018-10-16"),
                    TheLoai = "Sinh Ton",
                    GiaMua = 50.99M
                },
                new Game
                {
                    TenGame = "Horizon",
                    NgayMua = DateTime.Parse("2021-8-3"),
                    TheLoai = "Novel",
                    GiaMua = 60.99M
                }
                );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}

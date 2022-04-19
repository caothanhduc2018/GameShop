using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace GameShop.Models
{
    public class Game
    {
        public int Id { get; set; }
        [StringLength(30, ErrorMessage = "không quá {1} kí tự và không {2} kí tự đặc biệt", MinimumLength = 3)]
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Tên Game")]
        public string TenGame { get; set; }
        
        [Display(Name = "Ngày Mua")]
        [DataType(DataType.Date)]
        public DateTime NgayMua { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required(ErrorMessage = "Không được để trống")]

        [Display(Name = "Thể Loại")]
        
        public string TheLoai { get; set; }
        [Display(Name = "Giá Mua")]
        public decimal GiaMua { get; set; }
    }
}

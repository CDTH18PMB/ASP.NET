using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class PhongChieuModel
    {
        [Key]
        [Display(Name ="Mã")]
        public int MaPhong { get; set; }

        [Display(Name = "Số ghế")]
        [Range(0,180,ErrorMessage ="Số ghế phải từ 0 đến 180")]
        [Required(ErrorMessage = "Bạn cần nhập số ghế")]
        public int SoGhe { get; set; }

        [Display(Name = "Trạng Thái")]
        [Required(ErrorMessage = "Bạn cần thêm trạng thái")]
        public bool TrangThai { get; set; }

        
        public ICollection<VeModel> ListPhongChieu_Ve { get; set; }
        public ICollection<GheModel> ListPhongChieu_Ghe { get; set; }
        public ICollection<LichChieuModel> ListPhongChieu_LichChieu { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class VeModel
    {
        [Key]
        [DisplayName("Mã Vé")]
        public int MaVe { get; set; }

        //[Required(ErrorMessage ="Bạn cần chọn phim")]
        [DisplayName("Tên Phim")]
        public int? MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public virtual PhimModel maphim { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập giá vé")]
        [DisplayName("Giá Vé")]
        public int Gia { get; set; }

        //[Required(ErrorMessage = "Bạn cần chọn phòng")]
        [DisplayName("Phòng")]
        public int? MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public virtual PhongChieuModel maphong { get; set; }

        //[Required(ErrorMessage = "Bạn cần chọn vị trí ghế")]
        [DisplayName("Vị Trí Ghế")]
        public int MaGhe { get; set; }
        [ForeignKey("MaGhe")]
        public virtual GheModel maghe { get; set; }

        //[Required(ErrorMessage = "Bạn cần chọn suất chiếu")]
        [DisplayName("Suất Chiếu")]
        public int? SuatChieu { get; set; }
        [ForeignKey("SuatChieu")]
        public virtual LichChieuModel suatchieu { set; get; }

        [DisplayName("Ngày Mua")]
        public DateTime NgayMua { get; set; }

        //[Required(ErrorMessage = "Bạn cần chọn người mua")]
        [DisplayName("Người Mua")]
        public string NguoiMua { get; set; }
        [ForeignKey("NguoiMua")]
        public TaiKhoanModel nguoimua { get; set; }
    }
}

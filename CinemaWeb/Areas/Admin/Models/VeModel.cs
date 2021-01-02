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
        public int MaVe { get; set; }

        public int? MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public virtual PhimModel maphim { get; set; }

        public int? SuatChieu { get; set; }
        [ForeignKey("SuatChieu")]
        public virtual LichChieuModel suatchieu { set; get; }

        public int? MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public virtual PhongChieuModel maphong { get; set; }

        public int MaGhe { get; set; }
        [ForeignKey("MaGhe")]
        public virtual GheModel maghe { get; set; }

        public string Email { get; set; }
        [ForeignKey("Email")]
        public TaiKhoanModel email { get; set; }

        [Required]
        public int Gia { get; set; }

        [Required]
        public DateTime NgayMua { get; set; }

    }
}

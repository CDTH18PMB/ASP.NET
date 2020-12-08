using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class VeModel
    {   //mã vé
        [Key]
        public int mave { get; set; }
        //mã phim
        [Required]
        public int maphim { get; set; }
        [ForeignKey("maphim")]
        public virtual PhimModel phim { get; set; }
        //giá vé
        [Required]
        public int gia { get; set; }
        //mã phòng
        [Required]
        public int maphong { get; set; }
        [ForeignKey("maphong")]
        public virtual PhongChieuModel phongchieu { get; set; }
        //mã ghế
        [Required]
        public int maghe { get; set; }
        [ForeignKey("maghe")]
        public virtual GheModel ghe { get; set; }
        //Lịch chiếu phim
        [Required]
        public int suatchieu { get; set; }
        [ForeignKey("suatchieu")]
        public virtual LichChieuModel lichchieu { get; set; }
        //ngày mua vé
        [Required]
        public DateTime ngaymua { get; set; }
        //người mua vé
        [Required]
        public string nguoimua { get; set; }
        [ForeignKey("nguoimua")]
        public virtual TaiKhoanModel taikhoan { get; set; }
    }
}

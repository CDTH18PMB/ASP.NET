using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class GheModel
    {   //mã ghế
        [Key]
        public int MaGhe { get; set; }
        //mã phòng

        public int MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        
        //giá
        public int Gia { get; set; }
        //trạng thái
        public int TrangThai { get; set; }

        public int LichChieu { get; set; }
        [ForeignKey("LichChieu")]

        public virtual PhongChieuModel phongchieu { get; set; }
        public virtual LichChieuModel lichchieu { get; set; }
    }
}

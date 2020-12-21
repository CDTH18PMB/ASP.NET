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

        //public int MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public PhongChieuModel phong { get; set; }
        
        //giá
        public int Gia { get; set; }
        //trạng thái
        public int TrangThai { get; set; }

        //public int LichChieu { get; set; }
        [ForeignKey("LichChieu")]
        public LichChieuModel lichchieu { get; set; }

        //public virtual phongchieumodel phongchieu { get; set; }
        //public virtual lichchieumodel lichchieu { get; set; }
    }
}

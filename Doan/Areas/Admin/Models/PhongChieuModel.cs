using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class PhongChieuModel
    {
        //mã phòng
        [Key]
        public int MaPhong { get; set; }

        //số ghế
        public int SoGhe { get; set; }

        //trạng thái
        public int TrangThai { get; set; }

        //public ICollection<VeModel> ListVePhongChieu { get; set; }
        //public ICollection<GheModel> ListGhePhongChieu { get; set; }
        //public ICollection<LichChieuModel> ListLichChieuPhongChieu { get; set; }
    }
}

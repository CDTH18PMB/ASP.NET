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
        public int maphong { get; set; }
        //loại phòng
        [Required]
        [MaxLength(50)]
        [MinLength(10)]
        public string loaiphong { get; set; }
        //số ghế
        [Required]
        public int soghe { get; set; }
        //trạng thái
        public int trangthai { get; set; }

        public ICollection<VeModel> ListVePhongChieu { get; set; }
        public ICollection<GheModel> ListGhePhongChieu { get; set; }
        public ICollection<LichChieuModel> ListLichChieuPhongChieu { get; set; }
    }
}

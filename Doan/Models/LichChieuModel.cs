using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class LichChieuModel
    {
        //mã lịch chiếu
        [Key]
        public int malichchieu { get; set; }
        //ngày chiếu
        [Required]
        public DateTime ngaychieu { get; set; }
        //thời gian
        [Required]
        [MaxLength(10)]
        [MinLength(4)]
        public string thoigian { get; set; }
        //mã phim
        [Required]
        public int maphim { get; set; }
        [ForeignKey("maphim")]
        public virtual PhimModel phim { get; set; }
        //mã phòng
        [Required]
        public int maphong { get; set; }
        [ForeignKey("maphong")]
        public virtual PhongChieuModel phongchieu { get; set; }
        //số ghế trống
        public int soghetrong { get; set; }
    }
}

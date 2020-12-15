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
        public int MaLichChieu { get; set; }

        //ngày chiếu
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayChieu { get; set; }

        //thời gian
        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string ThoiGian { get; set; }

        //mã phim
        [Required]
        public int MaPhim { get; set; }
        [ForeignKey("maphim")]
    
        //mã phòng
        [Required]
        public int MaPhong { get; set; }
        [ForeignKey("MaPhong")]

        
        //số ghế trống
        public int SoGheTrong { get; set; }

        public virtual PhimModel Phim { get; set; }

        public virtual PhongChieuModel phongchieu { get; set; }

        public ICollection<GheModel> ListGhe { get; set; }
    }
}

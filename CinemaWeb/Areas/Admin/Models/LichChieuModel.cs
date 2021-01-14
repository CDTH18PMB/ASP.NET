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
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayChieu { get; set; }

        //thời gian
        [Required]
        [Column(TypeName = "Time")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan ThoiGian { get; set; }

        //mã phim
        [Required]
        [ForeignKey("MaPhim")]
        public PhimModel maphim { get; set; }

        //mã phòng
        [Required]
        [ForeignKey("MaPhong")]
        public PhongChieuModel maphong { get; set; }

        //số ghế trống
        [Required]
        public int SoGheTrong { get; set; }

        [Required]
        public bool TrangThai { get; set; }
    }
}

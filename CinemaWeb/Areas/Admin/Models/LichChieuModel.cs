using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace CinemaWeb.Areas.Admin.Models
{
    public class LichChieuModel
    {
        [Key]
        public int MaLichChieu { get; set; }

        //[Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayChieu { get; set; }

        //[Required]
        [StringLength(10, MinimumLength = 4)]
        [Column(TypeName = "nvarchar(10)")]
        public string ThoiGian { get; set; }

        //[Required]
        public int? MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public virtual PhimModel maphim { get; set; }

        //[Required]
        public int? MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public PhongChieuModel maphong { get; set; }

        [Required]
        public int SoGheTrong { get; set; }

        [Required]
        public bool TrangThai { get; set; }

        //
        public ICollection<GheModel> ListLichChieu_Ghe { get; set; }
        public ICollection<VeModel> ListLichChieu_Ve { get; set; }
    }
}

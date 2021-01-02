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

        public int? MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public virtual PhimModel maphim { get; set; }

        public int? MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public PhongChieuModel maphong { get; set; }

        [Required]
        public DateTime NgayChieu { get; set; }

        [Required]
        public int SoGheTrong { get; set; }

        [Required]
        public bool TrangThai { get; set; }



        public ICollection<VeModel> ListLichChieu_Ve { get; set; }
    }
}

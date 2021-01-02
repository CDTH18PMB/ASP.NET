using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class PhongChieuModel
    {
        [Key]
        public int MaPhong { get; set; }

        [Required]
        public int SoGhe { get; set; }

        [Required]
        public bool TrangThai { get; set; }

        
        public ICollection<VeModel> ListPhongChieu_Ve { get; set; }
        public ICollection<GheModel> ListPhongChieu_Ghe { get; set; }
        public ICollection<LichChieuModel> ListPhongChieu_LichChieu { get; set; }
    }
}

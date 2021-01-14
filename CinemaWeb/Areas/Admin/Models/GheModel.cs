using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class GheModel
    {
        [Key]
        public int MaGhe { get; set; }

        [Required]
        [Column(TypeName ="varchar(5)")]
        public string TenGhe { get; set; }

        [Required]
        public int Phong { get; set; }
        [ForeignKey("Phong")]
        public virtual PhongChieuModel maphong { get; set; }

        [Required]
        public bool TrangThai { get; set; }

        public ICollection<VeModel> ListGhe_Ve { get; set; }
    }
}

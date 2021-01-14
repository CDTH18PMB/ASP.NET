using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class TrangThaiGheModel
    {
        public int Id { get; set; }

        public int? Suat { get; set; }
        [ForeignKey("Suat")]
        public virtual LichChieuModel lichchieu { get; set; }

        public int Ghe { get; set; }
        [ForeignKey("Ghe")]
        public virtual GheModel ghemodel { get; set; }

        [Required]
        public bool TrangThai { get; set; }
    }
}

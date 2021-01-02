using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaWeb.Areas.Admin.Models
{
    public class TheloaiModel
    {
        [Key]
        public int MaLoai { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string TenLoai { get; set; }

        [Required]
        public bool TrangThai { get; set; }

        
        public ICollection<PhimModel> ListTheLoai_Phim { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    [Keyless]
    public class BinhLuanModel
    {
        public int MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public virtual PhimModel maphim { get; set; }

        public string Email { get; set; }
        [ForeignKey("Email")]
        public virtual TaiKhoanModel email { get; set; }

        [Required]
        [Column(TypeName ="text")]
        public string NoiDung { get; set; }

        [Required]
        public DateTime NgayDang { get; set; }

        [Required]
        public bool TrangThai { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class HoaDonModel
    {
        [Key]
        public int MaHD { get; set; }

        public string Email { get; set; }
        [ForeignKey("Email")]
        public virtual TaiKhoanModel email { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string VeDaDat { get; set; }

        [Required]
        public int TongTien { get; set; }

        [Required]
        public DateTime Ngay { get; set; }

        [Required]
        public bool TrangThai { get; set; }
    }
}

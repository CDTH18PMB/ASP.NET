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

        [Column(TypeName ="nvarchar(50)")]
        public string Username { get; set; }
        [ForeignKey("Username")]
        public virtual TaiKhoanModel username { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string VeDaDat { get; set; }

        public int TongTien { get; set; }

        public DateTime Ngay { get; set; }

        public bool TrangThai { get; set; }
    }
}

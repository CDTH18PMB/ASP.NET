using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class TaiKhoanModel
    {
        [Key]
        [Column(TypeName ="varchar(50)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string HoTen { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string SDT { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string LoaiTK { get; set; }

        [Required]
        public bool TrangThai { get; set; }

        
        public ICollection<HoaDonModel> ListTaiKhoan_HoaDon { get; set; }
        public ICollection<VeModel> ListTaiKhoan_Ve { get; set; }
    }
}

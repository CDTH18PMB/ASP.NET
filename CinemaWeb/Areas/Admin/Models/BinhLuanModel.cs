using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    [Keyless]
    public class BinhLuanModel
    {
        public int MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public PhimModel maphim { get; set; }

        public string Username { get; set; }
        [ForeignKey("Username")]
        public TaiKhoanModel username { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string NoiDung { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime NgayDang { get; set; }

        [Required]
        public bool TrangThai { get; set; }
    }
}

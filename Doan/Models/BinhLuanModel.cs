using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class BinhLuanModel
    {
        [Key]
        public int MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public string Username { get; set; }
        [ForeignKey("Username")]
        public string NoiDung { get; set; }
        public DateTime NgayDang { get; set; }
        public int TrangThai { get; set; }
        public virtual TaiKhoanModel taikhoan { get; set; }
        public virtual PhimModel phim { get; set; }
    }
}

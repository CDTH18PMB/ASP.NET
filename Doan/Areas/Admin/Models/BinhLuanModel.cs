using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Doan.Models
{
    
    public class BinhLuanModel
    {
        //public int MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public PhimModel phim { get; set; }
        //public string Username { get; set; }
        public string Username { get; set; }
        [ForeignKey("Username")]
        public virtual TaiKhoanModel taikhoan { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayDang { get; set; }
        public int TrangThai { get; set; }
        //public virtual TaiKhoanModel taikhoan { get; set; }
        //public virtual PhimModel phim { get; set; }
    }
}

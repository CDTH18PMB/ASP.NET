using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class HoaDonModel
    {
        [Key]
        public int MaHD { get; set; }

        public string Username { get; set; }
        [ForeignKey("Username")]
        
        public string VeDaDat { get; set; }
        public int TongTien { get; set; }
        public DateTime Ngay { get; set; }
        public int TrangThai { get; set; }
        public virtual TaiKhoanModel taikhoan { get; set; }
    }
}

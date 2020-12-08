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
        public int mahoadon { get; set; }
        public string username { get; set; }
        [ForeignKey("username")]
        public string vedadat { get; set; }
        public int tongtien { get; set; }
        public DateTime ngay { get; set; }
        public int trangthai { get; set; }
        public virtual TaiKhoanModel TaiKhoan { get; set; }
    }
}

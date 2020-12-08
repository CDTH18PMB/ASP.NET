using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class BinhLuanModel
    {
        public int maphim { get; set; }
        [ForeignKey("maphim")]
        public string username { get; set; }
        [ForeignKey("username")]
        public string noidung { get; set; }
        public DateTime ngaydang { get; set; }
        public int trangthai { get; set; }
        public virtual TaiKhoanModel TaiKhoan { get; set; }
    }
}

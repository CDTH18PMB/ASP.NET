using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class TaiKhoanModel
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public string hoten { get; set; }
        public char sdt { get; set; }
        public int lichsudat { get; set; }
        //khoa ngoai tu Hoadon mahd
        [ForeignKey("lichsudat")]
        public string loaitk { get; set; }
        public int trangthai { get; set; }
        public virtual HoaDonModel HoaDon { get; set; }
        public ICollection<BinhLuanModel> lstBinhLuan { get; set; }

        public ICollection<VeModel> ListTaiKhoan { get; set; }
    }
}

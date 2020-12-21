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
        public string Username { get; set; }
        public string Password { get; set; }
        public string HoTen { get; set; }
        public char SDT { get; set; }
        
        public string LoaiTK { get; set; }
        public int TrangThai { get; set; }

        //public ICollection<HoaDonModel> ListHoaDon { get; set; }

        //public ICollection<BinhLuanModel> listBinhLuan { get; set; }

        //public ICollection<VeModel> ListTaiKhoan { get; set; }
    }
}

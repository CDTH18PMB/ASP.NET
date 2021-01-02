using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    [Keyless]
    public class BinhLuanModel
    {
        public int MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public virtual PhimModel maphim { get; set; }

        public string Username { get; set; }
        [ForeignKey("Username")]
        public virtual TaiKhoanModel username { get; set; }

        public string NoiDung { get; set; }

        public DateTime NgayDang { get; set; }

        public bool TrangThai { get; set; }
    }
}

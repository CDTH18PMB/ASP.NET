using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class HoaDonModel
    {
        [Key]
        public int MaHD { get; set; }

        [Required]
        public string Username { get; set; }
        [ForeignKey("Username")]
        public virtual TaiKhoanModel username { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string GheDaDat { get; set; }

        [Required]
        public int TongTien { get; set; }

        [Required]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngay { get; set; }

        [Required]
        public bool TrangThai { get; set; }

        public HoaDonModel()
        {

        }

        public HoaDonModel(string username, string ghedadat, int tongtien, DateTime ngay, bool trangthai)
        {
            this.Username = username;
            this.GheDaDat = ghedadat;
            this.TongTien = tongtien;
            this.Ngay = ngay;
            this.TrangThai = trangthai;
        }
    }
}

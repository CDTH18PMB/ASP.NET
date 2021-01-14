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
        public TaiKhoanModel username { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string VeDaDat { get; set; }

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
        public HoaDonModel(string username, string ve, int tongtien, DateTime ngay, bool trangthai)
        {
            this.Username = username;
            this.VeDaDat = ve;
            this.TongTien = tongtien;
            this.Ngay = ngay;
            this.TrangThai = trangthai;
        }
    }
}

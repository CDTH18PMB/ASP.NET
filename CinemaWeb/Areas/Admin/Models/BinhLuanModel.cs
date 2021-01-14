using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaWeb.Areas.Admin.Models
{
    public class BinhLuanModel
    {
        [Key]
        public int MaBinhLuan { get; set; }

        public int Phim { get; set; }
        [ForeignKey("Phim")]
        public virtual PhimModel maphim { get; set; }

        public string NguoiDang { get; set; }
        [ForeignKey("NguoiDang")]
        public virtual TaiKhoanModel username { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(200)")]
        public string NoiDung { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayDang { get; set; }

        [Required]
        public bool TrangThai { get; set; }

        public BinhLuanModel()
        {

        }

        public BinhLuanModel(int maphim, string username, string noidung, DateTime ngay, bool trangthai)
        {
            this.Phim = maphim;
            this.NguoiDang = username;
            this.NoiDung = noidung;
            this.NgayDang = ngay;
            this.TrangThai = trangthai;
        }
    }
}

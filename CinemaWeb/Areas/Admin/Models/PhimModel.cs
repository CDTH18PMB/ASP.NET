using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Doan.Models
{
    public class PhimModel
    {
        [Key]
        public int MaPhim { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string TenPhim { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Poster { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string DaoDien { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Trailer { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ThoiLuong { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string NoiDung { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string QuocGia { get; set; }

        [Required]
        [ForeignKey("TheLoai")]
        public TheloaiModel theloai { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayKhoiChieu { get; set; }

        [Required]
        public bool TrangThai { get; set; }
    }
}

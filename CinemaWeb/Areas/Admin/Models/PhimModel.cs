using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CinemaWeb.Areas.Admin.Models
{
    public class PhimModel
    {
        [Key]
        public int MaPhim { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string TenPhim { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Poster { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string DaoDien { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Trailer { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string ThoiLuong { get; set; }

        [Column(TypeName = "text")]
        public string NoiDung { get; set; }

        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string QuocGia { get; set; }
        
        public int? TheLoai { get; set; }
        [ForeignKey("TheLoai")]
        public TheloaiModel theloai { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayKhoiChieu { get; set; } 

        [Required]
        public bool TrangThai { get; set; }

        //
        public ICollection<VeModel> ListPhim_Ve { get; set; }
        public ICollection<LichChieuModel> ListPhim_LichChieu { get; set; }
        //public ICollection<BinhLuanModel> ListPhim_BinhLuan { get; set; }

    }
}

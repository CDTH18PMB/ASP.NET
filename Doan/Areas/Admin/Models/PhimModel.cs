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
        [StringLength(100)]
        public string TenPhim { get; set; }

        [Required]
        [StringLength(50)]
        public string Poster { get; set; }

        [Required]
        [StringLength(100)]
        public string DaoDien { get; set; }

        [Required]
        [StringLength(50)]
        public string Trailer { get; set; }

        [Required]
        [StringLength(50)]
        public string ThoiLuong { get; set; }

        public string NoiDung { get; set; }

        [Required]
        [StringLength(20)]
        public string QuocGia { get; set; }
        
        //public int TheLoai { get; set; }
        [ForeignKey("Theloai")]
        public TheloaiModel theloai { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayKhoiChieu { get; set; } 

        public int TrangThai { get; set; }

        //public virtual TheloaiModel theloai { get; set; }

        //public ICollection<VeModel> ListVePhim { get; set; }
        //public ICollection<LichChieuModel> ListLichChieuPhim { get; set; }

    }
}

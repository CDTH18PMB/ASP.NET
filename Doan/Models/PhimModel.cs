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
        public int Maphim { get; set; }

        [Required]
        [StringLength(100)]
        public string Tenphim { get; set; }

        [Required]
        [StringLength(50)]
        public string Poster { get; set; }

        [Required]
        [StringLength(100)]
        public string Daodien { get; set; }

        [Required]
        [StringLength(50)]
        public string Trailer { get; set; }

        [Required]
        [StringLength(50)]
        public string Thoiluong { get; set; }

        public string Noidung { get; set; }

        [Required]
        [StringLength(20)]
        public string Quocgia { get; set; }

        
        public int Theloai { get; set; }
        [ForeignKey("Theloai")]
        public virtual TheloaiModel Theloaiphim { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ngayphat hanh")]
        public DateTime Ngayphathanh { get; set; } 

        public string Trangthai { get; set; }

        public ICollection<VeModel> ListVePhim { get; set; }
        public ICollection<LichChieuModel> ListLichChieuPhim { get; set; }

    }
}

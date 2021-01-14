using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class GheModel
    {   //mã ghế
        [Key]
        public int MaGhe { get; set; }

        [Required]
        [Column(TypeName = "char(5)")]
        public string TenGhe { get; set; }

        //mã phòng
        [Required]
        [ForeignKey("MaPhong")]
        public PhongChieuModel maphong { get; set; }

        //trạng thái
        [Required]
        public bool TrangThai { get; set; }
    }
}

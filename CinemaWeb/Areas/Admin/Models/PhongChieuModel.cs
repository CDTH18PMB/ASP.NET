using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class PhongChieuModel
    {
        //mã phòng
        [Key]
        public int MaPhong { get; set; }

        //số ghế
        [Required]
        public int SoGhe { get; set; }

        //trạng thái
        [Required]
        public bool TrangThai { get; set; }

        public ICollection<GheModel> lstGhe { get; set; }
    }
}

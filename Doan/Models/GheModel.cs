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
        public int maghe { get; set; }
        //mã phòng
        [Required]
        public int maphong { get; set; }
        [ForeignKey("maphong")]
        public virtual PhongChieuModel phongchieu { get; set; }
        //giá
        public int gia { get; set; }
        //trạng thái
        public int trangthai { get; set; }
    }
}

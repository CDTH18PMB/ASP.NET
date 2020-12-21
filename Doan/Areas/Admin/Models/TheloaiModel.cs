using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Doan.Models
{
    public class TheloaiModel
    {
        [Key]
        public int MaLoai { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLoai { get; set; }

        public string TrangThai { get; set; }
        //public ICollection<PhimModel> ListPhim { get; set; }
    }
}

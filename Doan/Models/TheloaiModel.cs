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
        public int Maloai { get; set; }

        [Required]
        [StringLength(100)]
        public string Tenloai { get; set; }

        public string Trangthai { get; set; }
        public ICollection<PhimModel> PhimList { get; set; }
    }
}

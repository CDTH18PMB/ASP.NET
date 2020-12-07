using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class Ve
    {
        public int ma_ve { get; set; }
        public int ma_phim { get; set; }
        public int gia { get; set; }
        public int ma_phong { get; set; }
        public int ma_ghe { get; set; }
        public int suat_chieu { get; set; }
        public DateTime ngay_mua { get; set; }
        public string nguoi_mua { get; set; }
    }
}

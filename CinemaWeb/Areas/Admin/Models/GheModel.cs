﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class GheModel
    {
        [Key]
        public int MaGhe { get; set; }

        [Required]
        [Column(TypeName ="char(5)")]
        public string TenGhe { get; set; }

        public int? MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public virtual PhongChieuModel maphong { get; set; }

        [Required]
        public bool TrangThai { get; set; }


        public ICollection<VeModel> ListGhe_Ve { get; set; }
    }
}

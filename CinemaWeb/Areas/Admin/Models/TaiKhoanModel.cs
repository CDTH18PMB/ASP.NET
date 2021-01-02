﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class TaiKhoanModel
    {
        [Key]
        [Column(TypeName ="nvarchar(20)")]
        public string Username { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string HoTen { get; set; }

        [Column(TypeName = "char(10)")]
        public string SDT { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string LoaiTK { get; set; }

        [Required]
        public bool TrangThai { get; set; }

        //
        public ICollection<HoaDonModel> ListTaiKhoan_HoaDon { get; set; }
        public ICollection<VeModel> ListTaiKhoan_Ve { get; set; }
        //public ICollection<BinhLuanModel> ListTaiKhoan_BinhLuan { get; set; }
    }
}

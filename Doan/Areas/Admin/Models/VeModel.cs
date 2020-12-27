﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Models
{
    public class VeModel
    {   //mã vé
        [Key]
        public int MaVe { get; set; }

        //mã phim
        //public int MaPhim { get; set; }
        [ForeignKey("MaPhim")]
        public PhimModel phim { get; set; }
        
        //giá vé
        public int Gia { get; set; }

        //mã phòng
        //public int MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public PhongChieuModel phong { get; set; }
        
        //mã ghế
        //public int MaGhe { get; set; }
        [ForeignKey("MaGhe")]
        public GheModel ghe { get; set; }
        
        //Lịch chiếu phim
        //public int SuatChieu { get; set; }
        [ForeignKey("SuatChieu")]
        public LichChieuModel lichchieu { set; get; }

        //ngày mua vé
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayMua { get; set; }

        //người mua vé
        //public string NguoiMua { get; set; }
        [ForeignKey("NguoiMua")]
        public TaiKhoanModel taikhoan { get; set; }

        //public virtual TaiKhoanModel taikhoan { get; set; }
        //public virtual PhimModel phim { get; set; }
        //public virtual PhongChieuModel phongchieu { get; set; }
        //public virtual GheModel ghe { get; set; }
        //public virtual LichChieuModel lichchieu { get; set; }
    }
}
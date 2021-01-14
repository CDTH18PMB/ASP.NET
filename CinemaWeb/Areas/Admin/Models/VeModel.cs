using System;
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
        [ForeignKey("MaPhim")]
        public PhimModel maphim { get; set; }

        //giá vé
        [Required]
        public int GiaVe { get; set; }

        //mã phòng
        [ForeignKey("MaPhong")]
        public PhongChieuModel maphong { get; set; }

        //mã ghế
        [ForeignKey("MaGhe")]
        public GheModel maghe { get; set; }

        //Lịch chiếu phim
        [ForeignKey("SuatChieu")]
        public LichChieuModel lichchieu { set; get; }


        //ngày mua vé
        [Required]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayMua { get; set; }

        //người mua vé
        [ForeignKey("NguoiMua")]
        public TaiKhoanModel nguoimua { get; set; }

        [Required]
        public bool TrangThai { get; set; }

        public VeModel()
        {

        }

        //public VeModel(int maphim, int gia, int maphong, int maghe, int suatchieu, string nguoimua, bool trangthai)
        //{
        //    this.maphim.MaPhim = maphim;
        //    this.GiaVe = gia;
        //    this.maphong.MaPhong = maphong;
        //    this.maghe.MaGhe = maghe;
        //    this.lichchieu.MaLichChieu = suatchieu;
        //    this.nguoimua.Username = nguoimua;
        //    this.TrangThai = trangthai;
        //}
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWeb.Areas.Admin.Models
{
    public class VeModel
    {
        [Key]
        [Display(Name = "Mã")]
        public int MaVe { get; set; }


        //========================================== Mã Phim =======================================================
        [Display(Name = "Tên Phim")]
        [Required(ErrorMessage = "Bạn cần thêm phim sẽ xem")]
        public int Phim { get; set; }
        [ForeignKey("Phim")]
        public virtual PhimModel maphim { get; set; }

        //========================================================================================================
        [Display(Name = "Giá vé")]
        [Required(ErrorMessage = "Bạn cần thêm giá vé")]
        [Range(1000, 100000, ErrorMessage = "giá vé phải từ 1.000 đến 100.000")]
        public int GiaVe { get; set; }


        //============================================ Mã Phòng ===========================================================
        [Display(Name = "Phòng")]
        //[Required(ErrorMessage = "Bạn cần thêm phòng chiếu")]
        public int? Phong { get; set; }
        [ForeignKey("Phong")]
        public virtual PhongChieuModel maphong { get; set; }


        //============================================= Mã Ghế ==============================================================
        [Display(Name = "Ghế ngồi")]
        [Required(ErrorMessage = "Bạn cần thêm ghế ngồi")]
        public int Ghe { get; set; }
        [ForeignKey("Ghe")]
        public virtual GheModel maghe { get; set; }


        //=============================================== Mã Lịch Chiếu ========================================================
        [Display(Name = "Suất chiếu")]
        //[Required(ErrorMessage = "Bạn cần thêm suất chiếu")]
        public int? Suat { get; set; }
        [ForeignKey("Suat")]
        public virtual LichChieuModel suatchieu { set; get; }


        //================================================ Người Mua ==========================================================
        [Display(Name = "Người mua")]
        [Required(ErrorMessage = "Bạn cần thêm người mua")]
        public string User { get; set; }
        [ForeignKey("User")]
        public TaiKhoanModel nguoimua { get; set; }

        //======================================================================================================================
        [Display(Name = "Ngày mua")]
        [Required(ErrorMessage = "Bạn cần thêm ngày mua")]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayMua { get; set; }


        [Display(Name = "Trạng thái")]
        [Required(ErrorMessage = "Bạn cần thêm trạng thái")]
        public bool TrangThai { get; set; }


        public VeModel()
        {

        }

        public VeModel(int phim, int gia, int phong, int ghe, int suat, DateTime ngay, string nguoimua, bool trangthai)
        {
            this.Phim = phim;
            this.GiaVe = gia;
            this.Phong = phong;
            this.Ghe = ghe;
            this.Suat = suat;
            this.NgayMua = ngay;
            this.User = nguoimua;
            this.TrangThai = trangthai;
        }
    }
}

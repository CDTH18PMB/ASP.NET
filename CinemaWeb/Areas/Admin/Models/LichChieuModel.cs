using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace CinemaWeb.Areas.Admin.Models
{
    public class LichChieuModel
    {
        [Key]
        [Display(Name ="Mã")]
        public int MaLichChieu { get; set; }

        //======================================================================================================================
        [Display(Name = "Ngày chiếu")]
        [Required(ErrorMessage = "Bạn cần thêm ngày chiếu")]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayChieu { get; set; }


        //======================================================================================================================
        [Display(Name = "thời gian chiếu")]
        [Required(ErrorMessage = "Bạn cần thêm thời gian chiếu")]
        [Column(TypeName = "Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan ThoiGian { get; set; }


        //=============================================== Mã Phim ===========================================================
        [Display(Name = "Tên Phim")]
        [Required(ErrorMessage = "Bạn cần thêm phim sẽ chiếu")]
        public int Phim { get; set; }
        [ForeignKey("Phim")]
        public virtual PhimModel maphim { get; set; }


        //=============================================== Mã Phòng =============================================================
        [Display(Name = "Phòng")]
        [Required(ErrorMessage = "Bạn cần thêm phòng chiếu")]
        public int Phong { get; set; }
        [ForeignKey("Phong")]
        public virtual PhongChieuModel maphong { get; set; }


        //======================================================================================================================
        [Display(Name ="Số ghế trống")]
        [Required(ErrorMessage = "Bạn cần thêm số ghế còn trống")]
        public int SoGheTrong { get; set; }


        [Display(Name ="Trạng thái")]
        [Required(ErrorMessage = "Bạn cần thêm trạng thái 0:kết thúc, 1:đang chiếu, 2:sấp chiếu")]
        [Range(0,2,ErrorMessage = "Trạng thái phải là 0:kết thúc, 1:đang chiếu, 2:sấp chiếu")]
        public bool TrangThai { get; set; }


        public ICollection<VeModel> ListLichChieu_Ve { get; set; }
    }
}

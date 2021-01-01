using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Doan.Models;

namespace Doan.Data
{
    public class DPContext : DbContext
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options) { }

        

        public DbSet<TaiKhoanModel> TaiKhoan { get; set; }
        public DbSet<TheloaiModel> TheLoai { get; set; }
        public DbSet<PhimModel> Phim { get; set; }
        public DbSet<LichChieuModel> LichChieu { get; set; }
        public DbSet<PhongChieuModel> PhongChieu { get; set; }
        public DbSet<GheModel> Ghe { get; set; }
        public DbSet<BinhLuanModel> BinhLuan { get; set; }
        public DbSet<HoaDonModel> HoaDon { get; set; }
        public DbSet<VeModel> Ve { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Doan.Models;

namespace CinemaWeb.Data
{
    public class DPContext : DbContext
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<BinhLuanModel>(eb =>
        //        {
        //            eb.HasNoKey();
        //            eb.ToView("View_BlogPostCounts");
        //            eb.Property(v => v.MaPhim).HasColumnName("MaPhim");
        //            eb.Property(v => v.Username).HasColumnName("Username");
        //        });
        //}

        public DbSet<TaiKhoanModel> TaiKhoan { get; set; }
        public DbSet<TheloaiModel> TheLoai { get; set; }
        public DbSet<PhimModel> Phim { get; set; }
        public DbSet<LichChieuModel> LichChieu { get; set; }
        public DbSet<PhongChieuModel> PhongChieu { get; set; }
        public DbSet<GheModel> Ghe { get; set; }
        public DbSet<HoaDonModel> HoaDon { get; set; }
        public DbSet<VeModel> Ve { get; set; }
        public DbSet<BinhLuanModel> BinhLuan { get; set; }
    }
}

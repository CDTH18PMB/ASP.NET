﻿// <auto-generated />
using System;
using CinemaWeb.Areas.Admin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemaWeb.Migrations
{
    [DbContext(typeof(DPContext))]
    partial class DPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.BinhLuanModel", b =>
                {
                    b.Property<int>("MaBinhLuan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiDang")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Phim")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaBinhLuan");

                    b.HasIndex("NguoiDang");

                    b.HasIndex("Phim");

                    b.ToTable("BinhLuan");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.GheModel", b =>
                {
                    b.Property<int>("MaGhe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Phong")
                        .HasColumnType("int");

                    b.Property<string>("TenGhe")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaGhe");

                    b.HasIndex("Phong");

                    b.ToTable("Ghe");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.HoaDonModel", b =>
                {
                    b.Property<int>("MaHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GheDaDat")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Ngay")
                        .HasColumnType("date");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("MaHD");

                    b.HasIndex("Username");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.LichChieuModel", b =>
                {
                    b.Property<int>("MaLichChieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("NgayChieu")
                        .HasColumnType("Date");

                    b.Property<int>("Phim")
                        .HasColumnType("int");

                    b.Property<int>("Phong")
                        .HasColumnType("int");

                    b.Property<int>("SoGheTrong")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("ThoiGian")
                        .HasColumnType("Time");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaLichChieu");

                    b.HasIndex("Phim");

                    b.HasIndex("Phong");

                    b.ToTable("LichChieu");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.PhimModel", b =>
                {
                    b.Property<int>("MaPhim")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DaoDien")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgayKhoiChieu")
                        .HasColumnType("Date");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("QuocGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TheLoai")
                        .HasColumnType("int");

                    b.Property<string>("ThoiLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaPhim");

                    b.HasIndex("TheLoai");

                    b.ToTable("Phim");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.PhongChieuModel", b =>
                {
                    b.Property<int>("MaPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("SoGhe")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaPhong");

                    b.ToTable("PhongChieu");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.TaiKhoanModel", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoaiTK")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("char(10)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Username");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.TheloaiModel", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaLoai");

                    b.ToTable("TheLoai");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.VeModel", b =>
                {
                    b.Property<int>("MaVe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Ghe")
                        .HasColumnType("int");

                    b.Property<int>("GiaVe")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayMua")
                        .HasColumnType("date");

                    b.Property<int>("Phim")
                        .HasColumnType("int");

                    b.Property<int?>("Phong")
                        .HasColumnType("int");

                    b.Property<int?>("Suat")
                        .HasColumnType("int");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("MaVe");

                    b.HasIndex("Ghe");

                    b.HasIndex("Phim");

                    b.HasIndex("Phong");

                    b.HasIndex("Suat");

                    b.HasIndex("User");

                    b.ToTable("Ve");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.BinhLuanModel", b =>
                {
                    b.HasOne("CinemaWeb.Areas.Admin.Models.TaiKhoanModel", "username")
                        .WithMany()
                        .HasForeignKey("NguoiDang");

                    b.HasOne("CinemaWeb.Areas.Admin.Models.PhimModel", "maphim")
                        .WithMany()
                        .HasForeignKey("Phim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("maphim");

                    b.Navigation("username");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.GheModel", b =>
                {
                    b.HasOne("CinemaWeb.Areas.Admin.Models.PhongChieuModel", "maphong")
                        .WithMany("ListPhongChieu_Ghe")
                        .HasForeignKey("Phong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("maphong");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.HoaDonModel", b =>
                {
                    b.HasOne("CinemaWeb.Areas.Admin.Models.TaiKhoanModel", "username")
                        .WithMany("ListTaiKhoan_HoaDon")
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("username");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.LichChieuModel", b =>
                {
                    b.HasOne("CinemaWeb.Areas.Admin.Models.PhimModel", "maphim")
                        .WithMany("ListPhim_LichChieu")
                        .HasForeignKey("Phim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaWeb.Areas.Admin.Models.PhongChieuModel", "maphong")
                        .WithMany("ListPhongChieu_LichChieu")
                        .HasForeignKey("Phong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("maphim");

                    b.Navigation("maphong");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.PhimModel", b =>
                {
                    b.HasOne("CinemaWeb.Areas.Admin.Models.TheloaiModel", "theloai")
                        .WithMany("ListTheLoai_Phim")
                        .HasForeignKey("TheLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("theloai");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.VeModel", b =>
                {
                    b.HasOne("CinemaWeb.Areas.Admin.Models.GheModel", "maghe")
                        .WithMany("ListGhe_Ve")
                        .HasForeignKey("Ghe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaWeb.Areas.Admin.Models.PhimModel", "maphim")
                        .WithMany("ListPhim_Ve")
                        .HasForeignKey("Phim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaWeb.Areas.Admin.Models.PhongChieuModel", "maphong")
                        .WithMany("ListPhongChieu_Ve")
                        .HasForeignKey("Phong");

                    b.HasOne("CinemaWeb.Areas.Admin.Models.LichChieuModel", "suatchieu")
                        .WithMany("ListLichChieu_Ve")
                        .HasForeignKey("Suat");

                    b.HasOne("CinemaWeb.Areas.Admin.Models.TaiKhoanModel", "nguoimua")
                        .WithMany("ListTaiKhoan_Ve")
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("maghe");

                    b.Navigation("maphim");

                    b.Navigation("maphong");

                    b.Navigation("nguoimua");

                    b.Navigation("suatchieu");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.GheModel", b =>
                {
                    b.Navigation("ListGhe_Ve");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.LichChieuModel", b =>
                {
                    b.Navigation("ListLichChieu_Ve");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.PhimModel", b =>
                {
                    b.Navigation("ListPhim_LichChieu");

                    b.Navigation("ListPhim_Ve");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.PhongChieuModel", b =>
                {
                    b.Navigation("ListPhongChieu_Ghe");

                    b.Navigation("ListPhongChieu_LichChieu");

                    b.Navigation("ListPhongChieu_Ve");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.TaiKhoanModel", b =>
                {
                    b.Navigation("ListTaiKhoan_HoaDon");

                    b.Navigation("ListTaiKhoan_Ve");
                });

            modelBuilder.Entity("CinemaWeb.Areas.Admin.Models.TheloaiModel", b =>
                {
                    b.Navigation("ListTheLoai_Phim");
                });
#pragma warning restore 612, 618
        }
    }
}

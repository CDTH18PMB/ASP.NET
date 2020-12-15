using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Doan.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongChieu",
                columns: table => new
                {
                    MaPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoGhe = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongChieu", x => x.MaPhong);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    LoaiTK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VeDaDat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    taikhoanUsername = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_TaiKhoan_taikhoanUsername",
                        column: x => x.taikhoanUsername,
                        principalTable: "TaiKhoan",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phim",
                columns: table => new
                {
                    MaPhim = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhim = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DaoDien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThoiLuong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuocGia = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TheLoai = table.Column<int>(type: "int", nullable: false),
                    NgayKhoiChieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    theloaiMaLoai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phim", x => x.MaPhim);
                    table.ForeignKey(
                        name: "FK_Phim_TheLoai_theloaiMaLoai",
                        column: x => x.theloaiMaLoai,
                        principalTable: "TheLoai",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuan",
                columns: table => new
                {
                    MaPhim = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    taikhoanUsername = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    phimMaPhim = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuan", x => x.MaPhim);
                    table.ForeignKey(
                        name: "FK_BinhLuan_Phim_phimMaPhim",
                        column: x => x.phimMaPhim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BinhLuan_TaiKhoan_taikhoanUsername",
                        column: x => x.taikhoanUsername,
                        principalTable: "TaiKhoan",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LichChieu",
                columns: table => new
                {
                    MaLichChieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayChieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGian = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaPhim = table.Column<int>(type: "int", nullable: false),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    SoGheTrong = table.Column<int>(type: "int", nullable: false),
                    PhimMaPhim = table.Column<int>(type: "int", nullable: true),
                    phongchieuMaPhong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichChieu", x => x.MaLichChieu);
                    table.ForeignKey(
                        name: "FK_LichChieu_Phim_PhimMaPhim",
                        column: x => x.PhimMaPhim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LichChieu_PhongChieu_phongchieuMaPhong",
                        column: x => x.phongchieuMaPhong,
                        principalTable: "PhongChieu",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ghe",
                columns: table => new
                {
                    MaGhe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    LichChieu = table.Column<int>(type: "int", nullable: false),
                    lichchieuMaLichChieu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ghe", x => x.MaGhe);
                    table.ForeignKey(
                        name: "FK_Ghe_LichChieu_lichchieuMaLichChieu",
                        column: x => x.lichchieuMaLichChieu,
                        principalTable: "LichChieu",
                        principalColumn: "MaLichChieu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ghe_PhongChieu_LichChieu",
                        column: x => x.LichChieu,
                        principalTable: "PhongChieu",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ve",
                columns: table => new
                {
                    MaVe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhim = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    MaGhe = table.Column<int>(type: "int", nullable: false),
                    SuatChieu = table.Column<int>(type: "int", nullable: false),
                    NgayMua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiMua = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    phimMaPhim = table.Column<int>(type: "int", nullable: true),
                    phongchieuMaPhong = table.Column<int>(type: "int", nullable: true),
                    gheMaGhe = table.Column<int>(type: "int", nullable: true),
                    lichchieuMaLichChieu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ve", x => x.MaVe);
                    table.ForeignKey(
                        name: "FK_Ve_Ghe_gheMaGhe",
                        column: x => x.gheMaGhe,
                        principalTable: "Ghe",
                        principalColumn: "MaGhe",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ve_LichChieu_lichchieuMaLichChieu",
                        column: x => x.lichchieuMaLichChieu,
                        principalTable: "LichChieu",
                        principalColumn: "MaLichChieu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ve_Phim_phimMaPhim",
                        column: x => x.phimMaPhim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ve_PhongChieu_phongchieuMaPhong",
                        column: x => x.phongchieuMaPhong,
                        principalTable: "PhongChieu",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ve_TaiKhoan_NguoiMua",
                        column: x => x.NguoiMua,
                        principalTable: "TaiKhoan",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuan_phimMaPhim",
                table: "BinhLuan",
                column: "phimMaPhim");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuan_taikhoanUsername",
                table: "BinhLuan",
                column: "taikhoanUsername");

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_LichChieu",
                table: "Ghe",
                column: "LichChieu");

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_lichchieuMaLichChieu",
                table: "Ghe",
                column: "lichchieuMaLichChieu");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_taikhoanUsername",
                table: "HoaDon",
                column: "taikhoanUsername");

            migrationBuilder.CreateIndex(
                name: "IX_LichChieu_PhimMaPhim",
                table: "LichChieu",
                column: "PhimMaPhim");

            migrationBuilder.CreateIndex(
                name: "IX_LichChieu_phongchieuMaPhong",
                table: "LichChieu",
                column: "phongchieuMaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Phim_theloaiMaLoai",
                table: "Phim",
                column: "theloaiMaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_gheMaGhe",
                table: "Ve",
                column: "gheMaGhe");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_lichchieuMaLichChieu",
                table: "Ve",
                column: "lichchieuMaLichChieu");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_NguoiMua",
                table: "Ve",
                column: "NguoiMua");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_phimMaPhim",
                table: "Ve",
                column: "phimMaPhim");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_phongchieuMaPhong",
                table: "Ve",
                column: "phongchieuMaPhong");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BinhLuan");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "Ve");

            migrationBuilder.DropTable(
                name: "Ghe");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "LichChieu");

            migrationBuilder.DropTable(
                name: "Phim");

            migrationBuilder.DropTable(
                name: "PhongChieu");

            migrationBuilder.DropTable(
                name: "TheLoai");
        }
    }
}

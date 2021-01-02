using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Doan.Migrations
{
    public partial class Database : Migration
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
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VeDaDat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_TaiKhoan_Username",
                        column: x => x.Username,
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
                    Theloai = table.Column<int>(type: "int", nullable: true),
                    NgayKhoiChieu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phim", x => x.MaPhim);
                    table.ForeignKey(
                        name: "FK_Phim_TheLoai_Theloai",
                        column: x => x.Theloai,
                        principalTable: "TheLoai",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuan",
                columns: table => new
                {
                    MaPhim = table.Column<int>(type: "int", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_BinhLuan_Phim_MaPhim",
                        column: x => x.MaPhim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BinhLuan_TaiKhoan_Username",
                        column: x => x.Username,
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
                    maphim = table.Column<int>(type: "int", nullable: false),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    SoGheTrong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichChieu", x => x.MaLichChieu);
                    table.ForeignKey(
                        name: "FK_LichChieu_Phim_maphim",
                        column: x => x.maphim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichChieu_PhongChieu_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "PhongChieu",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ghe",
                columns: table => new
                {
                    MaGhe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhong = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    LichChieu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ghe", x => x.MaGhe);
                    table.ForeignKey(
                        name: "FK_Ghe_LichChieu_LichChieu",
                        column: x => x.LichChieu,
                        principalTable: "LichChieu",
                        principalColumn: "MaLichChieu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ghe_PhongChieu_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "PhongChieu",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ve",
                columns: table => new
                {
                    MaVe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhim = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    MaPhong = table.Column<int>(type: "int", nullable: true),
                    MaGhe = table.Column<int>(type: "int", nullable: true),
                    SuatChieu = table.Column<int>(type: "int", nullable: true),
                    NgayMua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiMua = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ve", x => x.MaVe);
                    table.ForeignKey(
                        name: "FK_Ve_Ghe_MaGhe",
                        column: x => x.MaGhe,
                        principalTable: "Ghe",
                        principalColumn: "MaGhe",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ve_LichChieu_SuatChieu",
                        column: x => x.SuatChieu,
                        principalTable: "LichChieu",
                        principalColumn: "MaLichChieu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ve_Phim_MaPhim",
                        column: x => x.MaPhim,
                        principalTable: "Phim",
                        principalColumn: "MaPhim",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ve_PhongChieu_MaPhong",
                        column: x => x.MaPhong,
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
                name: "IX_BinhLuan_MaPhim",
                table: "BinhLuan",
                column: "MaPhim");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuan_Username",
                table: "BinhLuan",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_LichChieu",
                table: "Ghe",
                column: "LichChieu");

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_MaPhong",
                table: "Ghe",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_Username",
                table: "HoaDon",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_LichChieu_maphim",
                table: "LichChieu",
                column: "maphim");

            migrationBuilder.CreateIndex(
                name: "IX_LichChieu_MaPhong",
                table: "LichChieu",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Phim_Theloai",
                table: "Phim",
                column: "Theloai");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_MaGhe",
                table: "Ve",
                column: "MaGhe");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_MaPhim",
                table: "Ve",
                column: "MaPhim");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_MaPhong",
                table: "Ve",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_NguoiMua",
                table: "Ve",
                column: "NguoiMua");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_SuatChieu",
                table: "Ve",
                column: "SuatChieu");
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

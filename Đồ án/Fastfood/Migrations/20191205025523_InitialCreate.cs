using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fastfood.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monan",
                columns: table => new
                {
                    MonanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    Loai = table.Column<string>(nullable: true),
                    GiaMua = table.Column<int>(nullable: false),
                    GiaBan = table.Column<int>(nullable: false),
                    Soluong = table.Column<int>(nullable: false),
                    Nhacc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monan", x => x.MonanId);
                });

            migrationBuilder.CreateTable(
                name: "Nhanvien",
                columns: table => new
                {
                    NhanvienId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    Sodienthoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhanvien", x => x.NhanvienId);
                });

            migrationBuilder.CreateTable(
                name: "Hoadon",
                columns: table => new
                {
                    HoadonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngaylap = table.Column<DateTime>(nullable: false),
                    NhanvienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoadon", x => x.HoadonId);
                    table.ForeignKey(
                        name: "FK_Hoadon_Nhanvien_NhanvienId",
                        column: x => x.NhanvienId,
                        principalTable: "Nhanvien",
                        principalColumn: "NhanvienId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phieunhap",
                columns: table => new
                {
                    PhieunhapId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tongtien = table.Column<int>(nullable: false),
                    Ngaylap = table.Column<DateTime>(nullable: false),
                    NhanvienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phieunhap", x => x.PhieunhapId);
                    table.ForeignKey(
                        name: "FK_Phieunhap_Nhanvien_NhanvienId",
                        column: x => x.NhanvienId,
                        principalTable: "Nhanvien",
                        principalColumn: "NhanvienId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chitiethoadon",
                columns: table => new
                {
                    ChitiethoadonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soluong = table.Column<int>(nullable: false),
                    MonanId = table.Column<int>(nullable: true),
                    HoadonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitiethoadon", x => x.ChitiethoadonId);
                    table.ForeignKey(
                        name: "FK_Chitiethoadon_Hoadon_HoadonId",
                        column: x => x.HoadonId,
                        principalTable: "Hoadon",
                        principalColumn: "HoadonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chitiethoadon_Monan_MonanId",
                        column: x => x.MonanId,
                        principalTable: "Monan",
                        principalColumn: "MonanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chitietphieunhap",
                columns: table => new
                {
                    ChitietphieunhapId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soluong = table.Column<int>(nullable: false),
                    MonanId = table.Column<int>(nullable: true),
                    PhieunhapId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitietphieunhap", x => x.ChitietphieunhapId);
                    table.ForeignKey(
                        name: "FK_Chitietphieunhap_Monan_MonanId",
                        column: x => x.MonanId,
                        principalTable: "Monan",
                        principalColumn: "MonanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chitietphieunhap_Phieunhap_PhieunhapId",
                        column: x => x.PhieunhapId,
                        principalTable: "Phieunhap",
                        principalColumn: "PhieunhapId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chitiethoadon_HoadonId",
                table: "Chitiethoadon",
                column: "HoadonId");

            migrationBuilder.CreateIndex(
                name: "IX_Chitiethoadon_MonanId",
                table: "Chitiethoadon",
                column: "MonanId");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietphieunhap_MonanId",
                table: "Chitietphieunhap",
                column: "MonanId");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietphieunhap_PhieunhapId",
                table: "Chitietphieunhap",
                column: "PhieunhapId");

            migrationBuilder.CreateIndex(
                name: "IX_Hoadon_NhanvienId",
                table: "Hoadon",
                column: "NhanvienId");

            migrationBuilder.CreateIndex(
                name: "IX_Phieunhap_NhanvienId",
                table: "Phieunhap",
                column: "NhanvienId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chitiethoadon");

            migrationBuilder.DropTable(
                name: "Chitietphieunhap");

            migrationBuilder.DropTable(
                name: "Hoadon");

            migrationBuilder.DropTable(
                name: "Monan");

            migrationBuilder.DropTable(
                name: "Phieunhap");

            migrationBuilder.DropTable(
                name: "Nhanvien");
        }
    }
}

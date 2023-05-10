using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLKHCN_API.Migrations
{
    public partial class Dbinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    IDDanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    journal_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    issn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    eissn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    category_1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    category_2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    category_3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    category_4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    category_5 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    category_6 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    citations = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    if_2022 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    jci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    percentageOAGold = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.IDDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucScimago",
                columns: table => new
                {
                    number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    journal_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    issn = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    eissn = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    category_1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucScimago", x => x.number);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucXetDuyet",
                columns: table => new
                {
                    IDDanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    journal_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    issn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    eissn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    citations = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    if_2022 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    jci = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    percentageOAGold = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    userId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    rank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    link = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    tenBaiBao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    type = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    groupUser = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    quantity = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    total = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    dateSubmit = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucXetDuyet", x => x.IDDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    IDUser = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CCCD = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ChucDanh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DonViCongTac = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhongBan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TinhThanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailChinh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmailThayThe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SDTCoQuan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SDTDD = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.IDUser);
                });

            migrationBuilder.CreateTable(
                name: "QuyDoiGV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiSanPham = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MoTaLoaiSanPham = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TietChuan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Diem = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyDoiGV", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QuyDoiNCV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiSanPham = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MoTaLoaiSanPham = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    YeuCauTieuChuan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TietChuan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Diem = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyDoiNCV", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ThanhToanGV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiSanPham = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    YeuCauChatLuong = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    KinhPhi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MoTaLoaiSanPham = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToanGV", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ThanhToanNCV",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SanPhamKHCN = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TCNCKH = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    KinhPhi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MoTaSanPhamKHCN = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToanNCV", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "DanhMucScimago");

            migrationBuilder.DropTable(
                name: "DanhMucXetDuyet");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "QuyDoiGV");

            migrationBuilder.DropTable(
                name: "QuyDoiNCV");

            migrationBuilder.DropTable(
                name: "ThanhToanGV");

            migrationBuilder.DropTable(
                name: "ThanhToanNCV");
        }
    }
}

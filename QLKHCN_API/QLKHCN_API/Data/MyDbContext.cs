using Microsoft.EntityFrameworkCore;

namespace QLKHCN_API.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DanhMuc> DanhMuc { get; set; }
        public DbSet<DanhMucXetDuyet> DanhMucXetDuyet { get; set; }
        public DbSet<QuyDoiGV> QuyDoiGV { get; set; }
        public DbSet<QuyDoiNCV> QuyDoiNCV { get; set; }
        public DbSet<ThanhToanGV> ThanhToanGV { get; set; }
        public DbSet<ThanhToanNCV> ThanhToanNCV { get; set; }
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<DanhMucScimago> DanhMucScimago { get; set; }
    }
}
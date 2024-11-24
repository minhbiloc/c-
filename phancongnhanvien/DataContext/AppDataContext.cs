using Microsoft.EntityFrameworkCore;
using phancongnhanvien.Entities;

namespace phancongnhanvien.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Nhanvien> nhanviens { get; set; }
        public DbSet<DuAn> duAns { get; set; }
     
        public DbSet<PhanCong> phanCongs { get; set; }
    }
}

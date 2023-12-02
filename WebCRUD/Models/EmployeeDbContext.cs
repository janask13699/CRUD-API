using Microsoft.EntityFrameworkCore;

namespace WebCRUD.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GLLHAPB,initial catalog=Twilight,User Id=sa,Password=SmartWork@123;TrustServerCertificate=True");
        }
    }
}

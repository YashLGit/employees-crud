using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext()
        {

        }
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                "server=localhost;database=EmployeeDBTest;Trusted_Connection=true");
            }
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

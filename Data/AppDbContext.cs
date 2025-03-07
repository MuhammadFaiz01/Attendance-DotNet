using AttendanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<AttendanceRecord> AttendanceRecords => Set<AttendanceRecord>();
    }
}

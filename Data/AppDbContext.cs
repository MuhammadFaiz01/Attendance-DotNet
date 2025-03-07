using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AttendanceApp.Models;

namespace AttendanceApp.Data
{
    // Inherit dari IdentityDbContext agar tabel user & role Identity otomatis disertakan
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) 
        {
        }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<AttendanceRecord> AttendanceRecords => Set<AttendanceRecord>();
    }
}

using Microsoft.EntityFrameworkCore;
using ReportPortal.Server.Entities;

namespace ReportPortal.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)  { }

        // Prod Tables
        public DbSet<Department> Departments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportDepartment> ReportDepartments { get; set; }
        public DbSet<ReportRun> ReportRuns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDepartment> UserDepartments { get; set; }
    }
}
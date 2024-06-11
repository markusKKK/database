using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<HealthCheck> HealthChecks { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<AccessPermission> AccessPermissions { get; set; }
    }
}

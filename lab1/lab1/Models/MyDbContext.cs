using Microsoft.EntityFrameworkCore;

namespace lab1.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<WorkFor> WorksFor { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-J6LT3E6;Initial Catalog=EFCoreLab;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkFor>().HasKey(a => new { a.ESSN, a.Pno });
            base.OnModelCreating(modelBuilder);
        }

    }
}

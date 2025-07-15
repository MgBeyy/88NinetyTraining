using Microsoft.EntityFrameworkCore;
using University.Data.Context.ClassMappings;
using University.Data.Entities;

namespace University.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMapping());
            modelBuilder.ApplyConfiguration(new CourseMapping());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OGPV872;Database=UniversityApiDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}

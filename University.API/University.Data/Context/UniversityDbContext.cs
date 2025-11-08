using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using University.Data.Context.ClassMappings;
using University.Data.Entities;
using University.Data.Entities.Identity;

namespace University.Data.Context
{
    public class UniversityDbContext : IdentityDbContext<User,
        Role,
        int,
        UserClaim,
        UserRole,
        UserLogin,
        RoleClaim,
        UserToken
        >
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }


        public UniversityDbContext(DbContextOptions options) : base(options)
        {

        }


        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMapping());
            modelBuilder.ApplyConfiguration(new CourseMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new RoleMapping());
            modelBuilder.ApplyConfiguration(new RoleClaimMapping());
            modelBuilder.ApplyConfiguration(new UserClaimMapping());
            modelBuilder.ApplyConfiguration(new UserLoginMapping());
            modelBuilder.ApplyConfiguration(new UserTokenMapping());
            modelBuilder.ApplyConfiguration(new UserRoleMapping());


        }

    }
}

using EFCoreWithConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreWithConsoleApp.Contexts.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("CourseId");

            builder.HasMany(t => t.Assignments)
                .WithOne(t => t.Course)
                .HasForeignKey(t => t.CourseId);


        }
    }
}

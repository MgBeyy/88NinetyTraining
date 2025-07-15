using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Data.Entities;

namespace University.Data.Context.ClassMappings
{
    public class CourseMapping : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("CourseId");

            builder.Property(t => t.Title).HasMaxLength(256);

            builder.Property(t => t.Description)
                .HasColumnType("nvarchar(max)");
        }
    }
}

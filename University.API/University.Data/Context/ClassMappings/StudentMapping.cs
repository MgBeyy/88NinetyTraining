using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Data.Entities;

namespace University.Data.Context.ClassMappings
{
    public class StudentMapping : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("StudentId");

            builder.Property(t => t.Name).HasMaxLength(256);

            builder.HasIndex(t => t.Email)
                .IsUnique();

        }
    }
}

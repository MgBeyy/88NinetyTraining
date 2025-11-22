using EFCoreWithConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreWithConsoleApp.Contexts.Configurations
{
    internal class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.ToTable("Assignment");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("AssignmentId");

            builder.HasMany(t => t.Grades)
                .WithOne(t => t.Assignment)
                .HasForeignKey(t => t.AssignmentId);

            builder.HasMany(t => t.Comments)
                .WithOne(t => t.Assignment)
                .HasForeignKey(t => t.AssignmentId);
        }
    }
}

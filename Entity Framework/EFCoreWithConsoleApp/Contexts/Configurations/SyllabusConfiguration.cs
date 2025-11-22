using EFCoreWithConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreWithConsoleApp.Contexts.Configurations
{
    internal class SyllabusConfiguration : IEntityTypeConfiguration<Syllabus>
    {
        public void Configure(EntityTypeBuilder<Syllabus> builder)
        {
            builder.ToTable("Syllabus");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("SyllabusId");



        }
    }
}

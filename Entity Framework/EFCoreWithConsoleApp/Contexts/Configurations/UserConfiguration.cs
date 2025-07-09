using EFCoreWithConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EFCoreWithConsoleApp.Contexts.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("UserId");

            builder.HasIndex(t => t.EmailAdress)
                .IsUnique();

            builder.HasMany(t => t.Grades)
                .WithOne(t => t.Student)
                .HasForeignKey(t => t.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(t => t.Comments)
                .WithOne(t => t.CreatedByUser)
                .HasForeignKey(t => t.CreatedByUserId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}

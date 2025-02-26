using GradApp.Data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GradApp.Data.ModelsConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Email).IsUnique();
            builder.HasIndex(e => e.UserName).IsUnique();
            builder.Property(e => e.UserName).IsRequired().HasColumnName("User Name");
            builder.Property(e => e.Email).IsRequired().HasColumnName("Email");
            builder.Property(e => e.CreatedAt).HasDefaultValue("getdate()");
            builder.Property(e => e.UpdatedAt).HasDefaultValue("getdate()");
            builder.Property(e=>e.FirstName).IsRequired().HasColumnName("First Name").HasMaxLength(20);
            builder.Property(e=>e.LastName).IsRequired().HasColumnName("Last Name").HasMaxLength(20);
        }
    }
}

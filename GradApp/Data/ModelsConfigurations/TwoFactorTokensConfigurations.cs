using GradApp.Data.Models;
using GradApp.Data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GradApp.Data.ModelsConfigurations;

public class TwoFactorTokensConfigurations: IEntityTypeConfiguration<TwoFactorTokens>
{

    public void Configure(EntityTypeBuilder<TwoFactorTokens> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.UserId).IsUnique();
        builder.Property(e => e.UserId).IsRequired();
        builder.HasOne(e => e.user).WithOne(e => e.twoFactorTokens).HasForeignKey<User>(e => e.Id);
        builder.Property(e => e.CreatedAt).HasDefaultValue("getdate()");
        builder.Property(e => e.UpdatedAt).HasDefaultValue("getdate()");
    }

}

using GradApp.Data.Models;
using GradApp.Data.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GradApp.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            ApplyModelsConfigurations(builder);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { ConcurrencyStamp = "1", Name = "ADMIN", NormalizedName = "ADMIN" },
                new IdentityRole { ConcurrencyStamp = "2", Name = "USER", NormalizedName = "USER" }
                );
        }

        private void ApplyModelsConfigurations(ModelBuilder builder)
        {
        }

        public DbSet<TwoFactorTokens> TwoFactorTokens;

    }
}

using Microsoft.AspNetCore.Identity;

namespace GradApp.Data.Models.Identity
{
    public class User : IdentityUser
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public TwoFactorTokens twoFactorTokens{ get; set; } = null!;
    }
}

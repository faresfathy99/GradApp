using GradApp.Data.Models.Identity;

namespace GradApp.Data.Models;

public class TwoFactorTokens 
{
    public int Id { get; set;}
    public string UserId { get; set;} = null!;
    public string Token { get; set;} = null!;
    public User user{ get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace GradApp.Data.DTO;

public class Login2FADto
{
    [Required(ErrorMessage = "Please Enter your Email")]
    [EmailAddress]
    [RegularExpression("^\\S+@\\S+\\.\\S+$")]
    public string Email { get; set;} = null!;

    [Required(ErrorMessage = "Please Enter 2fa token")]
    public string Token{get; set;} = null!;
}

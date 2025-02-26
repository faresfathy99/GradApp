using System.ComponentModel.DataAnnotations;

namespace GradApp.Data.DTO;

public class LoginDto
{
    [Required(ErrorMessage = "Please Enter your Email")]
    [EmailAddress]
    [RegularExpression("^\\S+@\\S+\\.\\S+$")]
    public string Email { get; set;} = null!;

    [Required(ErrorMessage = "Please Enter your Password")]
    public string Password{get; set;} = null!;
}

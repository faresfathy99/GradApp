using GradApp.Data.DTO;
using GradApp.Data.Models;
using GradApp.Data.Models.Identity;

namespace GradApp.Services.Auth;

public interface IAuthService
{
    Task<ResponseModel<string>> Register(RegisterDto registerDto);
    Task<ResponseModel<User>> VerifyEmail(string UserId, string Token);
    Task<ResponseModel<LoginResponse>> Login(LoginDto loginDto);
    Task<ResponseModel<bool>> Logout();
}

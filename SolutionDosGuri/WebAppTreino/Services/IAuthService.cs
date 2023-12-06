using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Models.ResponseModels;

namespace WebAppTreino.Services;

public interface IAuthService
{
    Task<UserLoginInfo> Login(User user);
    Task<RegisterResponse> Register(User user);    
}

using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;

namespace WebAppTreino.Services;

public interface IAccountService
{
    Task<UserLoginInfo> Login(User user); 
}

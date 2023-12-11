using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;

namespace WebAppTreino.Services;

public class AccountService : IAccountService
{
    public async Task<UserLoginInfo> Login(User user)
    {
        return new UserLoginInfo("Login", "asdasdasdas", "Cesar");
    }
}

using FluentResults;
using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Repositories;

namespace WebAppTreino.Services;

public class AccountService : IAccountService
{
    private readonly IUserRepository _userRepository;

    public AccountService()
    {
        _userRepository = new UserRepository();
    }

    public async Task<Result<UserLoginInfo>> Login(User user)
    {
        var result = await _userRepository.Authenticate(user);
        if (result.IsFailed)
        {
            return Result.Fail("falhou");
        }

        return new UserLoginInfo("login", result.Value.Id.ToString(), result.Value.Name);
    }
}

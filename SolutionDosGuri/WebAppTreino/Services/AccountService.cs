using FluentResults;
using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Models.ResponseModels;
using WebAppTreino.Repositories;

namespace WebAppTreino.Services;

public class AccountService : IAccountService
{
    IUserRepository _userRepository;
    public AccountService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<Result<UserLoginInfo>> Login(User user)
    {
        return await _userRepository.Autheticate(user);
    }

    public async Task<Result<UserResponse>> Register(User user)
    {
        user.Id = Guid.NewGuid();
        user.Created = DateTime.Now;
        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
        return await _userRepository.Register(user);
    }

    public async Task<Result<List<UserResponse>>> ListUser(string query)
    {
        return await _userRepository.ListUsers(query);
    }
}

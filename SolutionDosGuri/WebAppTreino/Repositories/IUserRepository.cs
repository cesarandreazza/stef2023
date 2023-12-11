using FluentResults;
using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Models.ResponseModels;

namespace WebAppTreino.Repositories;

public interface IUserRepository
{
    Task<Result<UserResponse>> Register(User user);
    Task<bool> Delete(User user);
    Task<bool> Update(User user);
    Task<Result<UserLoginInfo>> Autheticate(User user);
    Task<Result<List<UserResponse>>> ListUsers(string query);
}

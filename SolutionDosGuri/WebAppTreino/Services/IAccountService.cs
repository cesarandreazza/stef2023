using FluentResults;
using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Models.ResponseModels;

namespace WebAppTreino.Services;

public interface IAccountService
{
    Task<Result<UserLoginInfo>> Login(User user);
    Task<Result<UserResponse>> Register(User user);    

    Task<Result<List<UserResponse>>> ListUser(string query);

}

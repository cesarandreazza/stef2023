using FluentResults;
using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;

namespace WebAppTreino.Services;

public interface IAccountService
{
    Task<Result<UserLoginInfo>> Login(User user); 
}

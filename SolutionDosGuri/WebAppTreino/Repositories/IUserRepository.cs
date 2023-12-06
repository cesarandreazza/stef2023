using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;

namespace WebAppTreino.Repositories;

public interface IUserRepository
{
    Task<string> Register(User user);
    Task<bool> Delete(User user);
    Task<bool> Update(User user);
    Task<UserLoginInfo> Autheticate(User user);
}

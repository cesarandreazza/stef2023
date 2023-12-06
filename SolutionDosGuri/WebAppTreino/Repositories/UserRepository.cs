using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;

namespace WebAppTreino.Repositories;

public class UserRepository : IUserRepository
{
    public Task<UserLoginInfo> Autheticate(User user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(User user)
    {
        throw new NotImplementedException();
    }

    public Task<string> Register(User user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(User user)
    {
        throw new NotImplementedException();
    }
}

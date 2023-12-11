using FluentResults;
using WebAppTreino.Models.DataModels;

namespace WebAppTreino.Repositories;

public class UserRepository : IUserRepository
{
    public async Task<Result<User>> Authenticate(User user)
    {
        if (user.Name == "Cesar")
        {
            return await Task.FromResult(Result.Fail("Usuário não encontrado."));
        }
        return await Task.FromResult(Result.Ok(user));
    }
}

using FluentResults;
using WebAppTreino.Models.DataModels;

namespace WebAppTreino.Repositories;

public interface IUserRepository
{
    Task<Result<User>> Authenticate(User user);
}

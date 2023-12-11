using FluentResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;
using WebAppTreino.Databases;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Models.ResponseModels;

namespace WebAppTreino.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _appDbContext;

    public UserRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<Result<UserLoginInfo>> Autheticate(User user)
    {
        var account = await _appDbContext.Users.SingleOrDefaultAsync(x => x.Email == user.Email);

        if (account == null || !BCrypt.Net.BCrypt.Verify(user.Password, account.Password))
        {
            return Result.Fail("Email ou senha inválidos");
        }
        else
        {
            return Result.Ok(new UserLoginInfo("", account.Id.ToString(), account.Name));
        }
    }

    public async Task<bool> Delete(User user)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<UserResponse>> Register(User user)
    {
        var result = await _appDbContext.Users.AddAsync(user);
        await _appDbContext.SaveChangesAsync();
        if (result == null || result.State == EntityState.Added)
        {
            return Result.Fail("Não foi possível registar o usuário");
        }
        return Result.Ok(new UserResponse()
        {
            Id = result.Entity.Id,
            Name = result.Entity.Name,
            Phone = result.Entity.Phone,
            Created = result.Entity.Created
        });
    }

    public async Task<bool> Update(User user)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<List<UserResponse>>> ListUsers(string query)
    {
        var result = await _appDbContext.Users
            .Where(p => p.Name.Contains(query))
            .ToListAsync<User>();
        if (result == null)
        {
            return Result.Fail("Não foi possível listar os usuários");
        }
        var listaRetorno = result.Select<User, UserResponse>(s => new UserResponse()
        {
            Id = s.Id,
            Name = s.Name,
            Phone = s.Phone,
            Created = s.Created
        }).ToList();

        return Result.Ok(listaRetorno);
    }
}

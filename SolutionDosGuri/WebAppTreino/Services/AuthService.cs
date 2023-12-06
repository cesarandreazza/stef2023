using Microsoft.AspNetCore.Identity;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Models.ResponseModels;
using WebAppTreino.Repositories;

namespace WebAppTreino.Services;

public class AuthService : IAuthService
{
    IUserRepository _userRepository;
    public AuthService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<UserLoginInfo> Login(User user)
    {
        return await _userRepository.Autheticate(user);
    }

    public Task<RegisterResponse> Register(User user)
    {
        return Task.FromResult<RegisterResponse>(new RegisterResponse() { Id = 1, Status = "OK", Message = "Cadastro realizado."});
    }
}

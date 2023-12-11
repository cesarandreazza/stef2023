using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Models.RequestModels;
using WebAppTreino.Models.ResponseModels;
using WebAppTreino.Services;

namespace WebAppTreino.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private IAccountService _authService;

    public LoginController(IAccountService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async  Task<IActionResult> Login([FromBody] UserRequest userRequest)
    {
        return Ok(await _authService.Login(new User() {Email = userRequest.Email!, Password = userRequest.Password! })); 
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] UserRegisterRequest user)
    {
        return Ok(await _authService.Register(new User() { Name = user.Name, Email = user.Email, Phone = user.PhoneNumber }));
    }

    [HttpPost("list")]
    public async Task<IActionResult> List([FromBody] string query)
    {
        return Ok(await _authService.ListUser(query));
    }
}

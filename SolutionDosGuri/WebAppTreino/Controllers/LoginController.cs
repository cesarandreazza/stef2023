using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Models.RequestModels;
using WebAppTreino.Services;
using FluentResults;


namespace WebAppTreino.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public LoginController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost(Name = "login")]
        public async Task<IActionResult> Login([FromBody] UserRequest userRequest)
        {
            var result = await _accountService.Login(new User() { Name = userRequest.UserName, Password = userRequest.Password });
            if (result.IsFailed)
            {
                return NotFound();
            }
            return Ok("Deu certo");
        }
    }
}

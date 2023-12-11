using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTreino.Models.DataModels;
using WebAppTreino.Models.RequestModels;
using WebAppTreino.Services;


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
        public IActionResult Login([FromBody] UserRequest userRequest)
        {
            return Ok(_accountService.Login(new User() { Name = userRequest.UserName, Password = userRequest.Password }));
        }
    }
}

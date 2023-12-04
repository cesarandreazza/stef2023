using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppTreino.RequestModels;
using WebAppTreino.ResponseModel;

namespace WebAppTreino.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost(Name = "login")]
        public IActionResult Login([FromBody] UserRequest user)
        {
            return new JsonResult(new UserResponse() { Id = 0, Name= user.UserName, Email = user.Password}); 
        }
    }
}

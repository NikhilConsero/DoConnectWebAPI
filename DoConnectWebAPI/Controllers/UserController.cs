using DoConnectEntity;
using DoConnectService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoConnectWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody]Users user)
        {
            _userService.Regitser(user);
            return Ok("User Registered Successfully");
        }
        //[HttpPost]
        //public IActionResult Login(string email, string password)
        //{
        //    Users usr = _userService.Login(email, password);
        //    if (usr != null)
        //    {
        //        return Ok("Login Successfull");
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
    }
}

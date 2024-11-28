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
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _userService.GetUsers();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddUser(Users u)
        {
            _userService.AddUser(u);
            object result = "Product Added Successfully";
            return Ok(result);
        }
    }
}

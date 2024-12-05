using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DoConnectEntity;
using DoConnectRepository.Data;
using DoConnectService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace DoConnectWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        private readonly DoConnectDbContext _context;
        private IConfiguration _config;
        public UserController(IConfiguration configuration, DoConnectDbContext context, IUserService userService)
        {
            _config = configuration;
            _context = context;
            _userService = userService;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody]Users user)
        {
            _userService.Regitser(user);
            return Ok("User Registered Successfully");
        }
        private string GenerateJSONWebToken(Users userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.username),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.email),
                new Claim("UserID", userInfo.id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        [HttpPost("Login")]
        public IActionResult Login(string email, string password)
        {
            Users usr = _userService.Login(email, password);
            if (usr != null)
            {
                var res = (GenerateJSONWebToken(usr));
                return Ok(res);
            }
            else
            {
                return NotFound();
            }
        }
    }
}

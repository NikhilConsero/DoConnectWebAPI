using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DoConnectEntity;
using DoConnectRepository.Data;
using DoConnectService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DoConnectWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly DoConnectDbContext _context;
        private readonly IUserService _userService;
        public TokenController(IConfiguration configuration, DoConnectDbContext context, IUserService userService)
        {
            _configuration = configuration;
            _context = context;
            _userService = userService;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Post(Users _userData)
        {

            if (_userData != null && _userData.email != null && _userData.password != null)
            {
                var usr = await GetUser(_userData.email, _userData.password);

                if (usr != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("Id", usr.id.ToString()),
                        new Claim("FirstName", usr.FirstName),
                        new Claim("LastName", usr.LastName),
                        new Claim("Email", usr.email), 
                       };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }
        private async Task<Users> GetUser(string email, string password)
        {
            Users user = _userService.Login(email,password);
            return user;
            //UserInfo userInfo = null;
            //var result = _context.userInfo.Where(u => u.Email == email && u.Password == password);
            //foreach (var item in result)
            //{
            //    userInfo = new UserInfo();
            //    userInfo.UserId = item.UserId;
            //    userInfo.Firstname = item.Firstname;
            //    userInfo.Lastname = item.Lastname;
            //    userInfo.Email = item.Email;
            //    userInfo.Mobile = item.Mobile;
            //}
            //return userInfo;

        }
    }
}

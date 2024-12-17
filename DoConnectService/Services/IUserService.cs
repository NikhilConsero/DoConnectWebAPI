using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;

namespace DoConnectService.Services
{
    public interface IUserService
    {
        public Task Regitser(Users user);
        public Task<Users> Login(string email,string password);
    }
}

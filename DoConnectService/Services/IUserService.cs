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
        void AddUser(Users users);
        List<Users> GetUsers();
    }
}

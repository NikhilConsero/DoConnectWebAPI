using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;
using DoConnectRepository.Repositories;

namespace DoConnectService.Services
{
    public class UserService : IUserService
    {
        IUserRepository _users;
        public void AddUser(Users u)
        {
            _users.AddUser(u);
        }

        public List<Users> GetUsers()
        {
            return _users.GetAll();
        }
    }
}
    
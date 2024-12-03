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
        IUserRepository _repository;
        public UserService(IUserRepository users)
        {
            _repository = users; 
        }

        public Users Login(string email, string password)
        {
            return _repository.Login(email,password);
        }

        public void Regitser(Users user)
        {
           _repository.Register(user);
        }
    }
}
    
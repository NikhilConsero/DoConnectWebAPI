using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;

namespace DoConnectRepository.Repositories
{
    public interface IUserRepository
    {
        void Register(Users user);
        Users Login(string email,string password);
    }   
}

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
        void AddUser(Users u);
        void UpdateUser();
        void DeleteUser();
        List<Users> GetAll(); 
    }   
}

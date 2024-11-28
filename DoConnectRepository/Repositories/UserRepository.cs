using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;
using DoConnectRepository.Data;
using Microsoft.EntityFrameworkCore;

namespace DoConnectRepository.Repositories
{
    public class UserRepository : IUserRepository
    {
        UserContext _repository;
        public UserRepository(UserContext userdbcontext) 
        {
            _repository = userdbcontext;
        }
        public void AddUser(Users u)
        {
            _repository.Userslist.Add(u);
            _repository.SaveChanges();//Execute Query  
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
    
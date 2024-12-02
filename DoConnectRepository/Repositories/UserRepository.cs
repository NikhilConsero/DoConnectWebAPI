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
        UserDbContext _context;
        public UserRepository(UserDbContext userdbcontext) 
        {
            _context = userdbcontext;
        }
        public void AddUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();//Execute Query  
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public Users GetUsersbyUsername()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
    
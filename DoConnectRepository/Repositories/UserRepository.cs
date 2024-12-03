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
        DoConnectDbContext _context;
        public UserRepository(DoConnectDbContext userdbcontext) 
        {
            _context = userdbcontext;
        }
        public  void Register(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public Users Login(string email,string password)
        {
            Users userinfo = null; 
            var result = _context.Users.Where(obj => obj.email == email && obj.password==password).ToList();
            if (result.Count() > 0)
            {
                userinfo= result[0];
            }
            return userinfo;
        }
    }
}   
    
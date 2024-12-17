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
        public async Task Register(Users user)
        {
            await _context.Users.AddAsync(user);
            _context.SaveChanges();
        }

        public async Task<Users> Login(string email,string password)
        {
            Users userinfo = null; 
            var result = await _context.Users.Where(obj => obj.email == email && obj.password==password).ToListAsync();
            if (result.Count() > 0)
            {
                userinfo= result[0];
            }
            return userinfo;
        }
    }
}   
    
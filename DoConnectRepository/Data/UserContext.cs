using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectRepository.Repositories;
using Microsoft.EntityFrameworkCore;
using DoConnectEntity;

namespace DoConnectRepository.Data
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options):base(options) 
        {

        }
        public DbSet<Users> Userslist { get; set; }
    }
}

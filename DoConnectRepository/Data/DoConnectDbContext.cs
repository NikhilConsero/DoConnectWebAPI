using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoConnectEntity;

namespace DoConnectRepository.Data
{
    public class DoConnectDbContext:DbContext
    {
        public DoConnectDbContext(DbContextOptions<DoConnectDbContext> options) : base(options)
        { 
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Questions> Questions { get; set; }
    }
}

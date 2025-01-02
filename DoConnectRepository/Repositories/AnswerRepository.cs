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
    public class AnswerRepository : IAnswerRepository
    {
        DoConnectDbContext _dbcontext;
        public AnswerRepository(DoConnectDbContext context)
        {
            _dbcontext = context;
        }
        public async Task AddAnswer(Answers answer)
        {
            await _dbcontext.Answers.AddAsync(answer);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task DeleteAnswer(int id)
        {
            Answers obj=await _dbcontext.Answers.FindAsync(id);
            _dbcontext.Remove(obj);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<Answers> GetAnswerByID(int id)
        {
            Answers obj = await _dbcontext.Answers.FindAsync(id);
            return obj;
        }

        public async Task<int> GetApprovedCount(string username)
        {
            int res= await _dbcontext.Answers.Where(x=> x.Username == username && x.approved=="Y").CountAsync();
            return res;
        }

        public async  Task<int> GetUnapprovedCount(string username)
        {
            int res= await _dbcontext.Answers.Where(x=>x.Username == username && x.approved=="N").CountAsync();
            return res;
        }

        public async Task<List<Answers>> GetUsersAnswer(string username)
        {
            var list=await _dbcontext.Answers.Where(x=>x.Username==username).ToListAsync();
            return list;
        }

        public async  Task<int> WaitApprovedCount(string username)
        {
            int res = await _dbcontext.Answers.Where(x => x.Username == username && x.approved == "W").CountAsync(); 
            return res;
        }
        public async Task<int> GetTotalUnapprove()
        {
            int res = await _dbcontext.Answers.Where(x => x.approved == "W").CountAsync();
            return res;
        }

        public async Task<int> GetTotalAnswer(string username)
        {
            int res = await _dbcontext.Answers.Where(x => x.Username == username).CountAsync();
            return res;
        }
    }
}

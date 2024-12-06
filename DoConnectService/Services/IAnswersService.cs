using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;

namespace DoConnectService.Services
{
    public interface IAnswersService
    {
        public Task AddAnswer(Answers answer);
        public Task DeleteAnswer(int id);
        public Task<Answers> GetAnswersById(int id);
        public Task<List<Answers>> GetUsersAnswer(string username);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;

namespace DoConnectRepository.Repositories
{
    public interface IAnswerRepository
    {
        public Task AddAnswer(Answers answer);
        public Task DeleteAnswer(int id);
        public Task<Answers> GetAnswerByID(int id);
        public Task<List<Answers>> GetUsersAnswer(string username);

    }
}

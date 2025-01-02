using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;
using DoConnectRepository.Repositories;

namespace DoConnectService.Services
{
    public class AnswerService : IAnswersService
    {
        IAnswerRepository _repository;
        public AnswerService(IAnswerRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAnswer(Answers answer)
        {
            await _repository.AddAnswer(answer);
        }

        public async Task DeleteAnswer(int id)
        {
            await _repository.DeleteAnswer(id);
        }

        public async Task<Answers> GetAnswersById(int id)
        {
            var result =await _repository.GetAnswerByID(id);
            return result;
        }

        public async Task<int> GetApprovedCount(string username)
        {
            int res = await _repository.GetApprovedCount(username);
            return res;
        }

        public async Task<int> GetTotalUnapprove()
        {
            int res =await _repository.GetTotalUnapprove();
            return res;
        }

        public async Task<int> GetUnapprovedCount(string username)
        {
            int res = await _repository.GetUnapprovedCount(username);
            return res;
        }

        public async Task<List<Answers>> GetUsersAnswer(string username)
        {
            var result = await _repository.GetUsersAnswer(username);
            return result;
        }

        public async Task<int> WaitApprovedCount(string username)
        {
            int res = await _repository.WaitApprovedCount(username);
            return res;

        }
        public async Task<int> GetTotalAnswer(string username)
        {
            int res = await _repository.GetTotalAnswer(username);
            return res;
        }
    }
}

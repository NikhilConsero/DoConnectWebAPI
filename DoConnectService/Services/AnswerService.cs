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

        public async Task<List<Answers>> GetUsersAnswer(string username)
        {
            var result = await _repository.GetUsersAnswer(username);
            return result;
        }
    }
}

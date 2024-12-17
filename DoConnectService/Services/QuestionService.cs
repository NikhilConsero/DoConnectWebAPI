using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;
using DoConnectRepository.Repositories;

namespace DoConnectService.Services
{
    public class QuestionService : IQuestionService
    {
        IQuestionRepository _repository;
        public QuestionService(IQuestionRepository repository)
        {
            _repository = repository;
        }
        public async Task AskQuestion(Questions question)
        {
            await _repository.AskQuestion(question);
        }

        public async Task DeleteQuestion(int id)
        {
            await _repository.DeleteQuestion(id);
        }

        public async Task<Questions> GetQuestionByID(int id)
        {
            return await  _repository.GetQuestionsById(id);
        }

        public async Task<List<Questions>> GetUsersQuestion(string username)
        {
            return await _repository.GetUsersQuestion(username);
        }
    }
}

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
        public void AskQuestion(Questions question)
        {
            _repository.AskQuestion(question);
        }

        public void DeleteQuestion(int id)
        {
            _repository.DeleteQuestion(id);
        }

        public Questions GetQuestionByID(int id)
        {
            return _repository.GetQuestionsById(id);
        }

        public List<Questions> GetUsersQuestion(string username)
        {
            return _repository.GetUsersQuestion(username);
        }
    }
}

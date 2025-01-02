using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;
using DoConnectRepository.Repositories;
using Microsoft.EntityFrameworkCore;

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

        public async Task<int> GetApprovedCount(string username)
        {
            int res = await _repository.GetApprovedCount(username);
            return res;
        }

        public async Task<Questions> GetQuestionByID(int id)
        {
            return await _repository.GetQuestionsById(id);
        }

        public async Task<int> GetTotalUnapprove()
        {
            int res = await _repository.GetTotalUnapprove();
            return res;
        }

        public async Task<int> GetUnapprovedCount(string username)
        {
            int res = await _repository.GetUnapprovedCount(username);
            return res;
        }

        public async Task<List<Questions>> GetUsersQuestion(string username)
        {
            return await _repository.GetUsersQuestion(username);
        }

        public async Task<int> WaitApprovedCount(string username)
        {
            int res = await _repository.WaitApprovedCount(username);
            return res;
        }
        public async Task<int> GetTotalQuestion(string username)
        {
            int res = await _repository.GetTotalQuestion(username);
            return res;
        }
        public async Task<List<Questions>> GetAllQuestion()
        {

            var list = await _repository.GetAllQuestion();
            //var result =list.Find(x => x.username == username).tol;
            return list;
        }
    }
}

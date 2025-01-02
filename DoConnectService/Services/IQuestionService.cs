using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;

namespace DoConnectService.Services
{
    public interface IQuestionService
    {
        Task AskQuestion(Questions question);
        Task DeleteQuestion(int id);
        Task<Questions> GetQuestionByID(int id);
        Task<List<Questions>> GetUsersQuestion(string username);
        public Task<int> GetApprovedCount(string username);
        public Task<int> GetUnapprovedCount(string username);
        public Task<int> WaitApprovedCount(string username);
        public Task<int> GetTotalUnapprove();
        public Task<int> GetTotalQuestion(string username);
        public Task<List<Questions>> GetAllQuestion();
    }
}

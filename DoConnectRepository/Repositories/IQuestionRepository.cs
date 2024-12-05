using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;

namespace DoConnectRepository.Repositories
{
    public interface IQuestionRepository
    {
        void AskQuestion(Questions question);
        void DeleteQuestion(int id);
        public Questions GetQuestionsById(int id);
        public List<Questions> GetUsersQuestion(string username);
    }
}

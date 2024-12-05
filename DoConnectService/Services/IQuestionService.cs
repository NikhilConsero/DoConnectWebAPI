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
        void AskQuestion(Questions question);
        void DeleteQuestion(int id);
        Questions GetQuestionByID(int id);
        List<Questions> GetUsersQuestion(string username);

    }
}

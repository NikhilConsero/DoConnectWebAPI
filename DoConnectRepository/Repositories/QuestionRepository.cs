using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoConnectEntity;
using DoConnectRepository.Data;
using Microsoft.EntityFrameworkCore;

namespace DoConnectRepository.Repositories
{
    public class QuestionRepository:IQuestionRepository
    {       
        DoConnectDbContext _dbcontext;
        public QuestionRepository(DoConnectDbContext context)
        {
            _dbcontext = context;

        }

        public void AskQuestion(Questions question)
        {
            _dbcontext.Questions.Add(question);
            _dbcontext.SaveChanges();
        }

        public void DeleteQuestion(int id)
        {
            Questions obj = _dbcontext.Questions.Find(id);
            _dbcontext.Remove(obj);
        }

        public Questions GetQuestionsById(int id)
        {
            Questions obj= _dbcontext.Questions.Find(id);
            return obj;
        }

        public List<Questions> GetUsersQuestion(string username)
        {

            var list= _dbcontext.Questions.Where(x=>x.username==username).ToList();
            //var result =list.Find(x => x.username == username).tol;
            return list;
        }
    }
}
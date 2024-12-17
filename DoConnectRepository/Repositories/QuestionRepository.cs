﻿using System;
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

        public async Task AskQuestion(Questions question)
        {
            await _dbcontext.Questions.AddAsync(question);
            _dbcontext.SaveChanges();
        }

        public async Task DeleteQuestion(int id)
        {
             Questions obj = await _dbcontext.Questions.FindAsync(id);
            _dbcontext.Remove(obj);
        }

        public async Task<Questions> GetQuestionsById(int id)
        {
            Questions obj= await _dbcontext.Questions.FindAsync(id);
            return obj;
        }

        public async Task<List<Questions>> GetUsersQuestion(string username)
        {

            var list= await _dbcontext.Questions.Where(x=>x.username==username).ToListAsync();
            //var result =list.Find(x => x.username == username).tol;
            return list;
        }
    }
}
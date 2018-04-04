using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace QuizDataLibrary
{
    public class AnswerRepoEf : IAnswer
    {
        private readonly QuizTakerDbContext _dbContext;

        public AnswerRepoEf(QuizTakerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddAnswer(Answer newAnswer)
        {
            _dbContext.Answers.Add(newAnswer);
            _dbContext.SaveChanges();
        }

        public void DeleteAnswer(Answer deleteAnswer)
        {
            _dbContext.Answers.Remove(deleteAnswer);
            _dbContext.SaveChanges();
        }

        public void EditAnswer(Answer editAnswer)
        {
            _dbContext.Entry(editAnswer).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public Answer GetById(int id)
        {
            return _dbContext.Answers.Find(id);
        }

        public List<Answer> List()
        { 
            return _dbContext.Answers
                .ToList();
        }
    }
}

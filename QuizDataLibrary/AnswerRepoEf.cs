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

        public Answer AddAnswer(Answer newAnswer)
        {
            _dbContext.Answers.Add(newAnswer);
            _dbContext.SaveChanges();
            return newAnswer;
        }

        public void DeleteAnswer(int id)
        {
            var deleteAnswer = _dbContext.Answers.FirstOrDefault(i => i.AnswerId == id);
            _dbContext.Answers.Remove(deleteAnswer);
            _dbContext.SaveChanges();
        }

        public void EditAnswer(Answer editAnswer)
        {
            _dbContext.Entry(editAnswer).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public List<Answer> ListAllAnswers()
        {
            return _dbContext.Answers
                .ToList();
        }

        public Answer GetById(int id)
        {
            return ListAllAnswers()
                .Where(a => a.AnswerId == id)
                .FirstOrDefault();
        }  
    }
}

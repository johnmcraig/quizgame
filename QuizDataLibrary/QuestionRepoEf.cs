using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace QuizDataLibrary
{
    public class QuestionRepoEf : IQuestion
    {
        private readonly QuizTakerDbContext _dbContext;

        public QuestionRepoEf(QuizTakerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Question AddQuestion(Question newQuestion)
        {
            _dbContext.Questions.Add(newQuestion);
            _dbContext.SaveChanges();
            return newQuestion;
        }

        public void DeleteQuestion(Question deleteQuestion)
        {
            _dbContext.Questions.Remove(deleteQuestion);
            _dbContext.SaveChanges();
        }

        public void EditQuestion(Question editQuestion)
        {
            _dbContext.Entry(editQuestion).State = EntityState.Modified;
        }

        public Question GetById(int id)
        {
            return _dbContext.Questions.Find();
        }

        public List<Question> List()
        {
            return _dbContext.Questions
                .ToList();
        }
    }
}

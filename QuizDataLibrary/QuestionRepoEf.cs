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

        public void DeleteQuestion(int id)
        {
            var deleteQuestion = _dbContext.Questions.FirstOrDefault(i => i.QuestionId == id);
            _dbContext.Questions.Remove(deleteQuestion);
            _dbContext.SaveChanges();
        }

        public void EditQuestion(Question editQuestion)
        {
            _dbContext.Entry(editQuestion).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public List<Question> ListAllQuestions()
        {
            return _dbContext.Questions
                .ToList();
        }

        public Question GetById(int id)
        {
            return ListAllQuestions()
                .Where(q => q.QuestionId == id)
                .FirstOrDefault();
        }
      
    }
}

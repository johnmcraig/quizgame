using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizDataLibrary
{
    public class QuizRepoEf : IQuiz
    {
        private readonly QuizTakerDbContext _dbContext;

        public QuizRepoEf(QuizTakerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Quiz AddQuiz(Quiz newQuiz)
        {
            _dbContext.Quizzes.Add(newQuiz);
            _dbContext.SaveChanges();
            return newQuiz;
        }

        public void EditQuiz(Quiz editQuiz)
        {
            _dbContext.Entry(editQuiz).State = EntityState.Modified;
            _dbContext.SaveChanges();

        }

        public void DeleteQuiz(Quiz deleteQuiz)
        {
            _dbContext.Quizzes.Remove(deleteQuiz);
            _dbContext.SaveChanges();
        }

        public List<Quiz> ListAllQuizzes()
        {
            return _dbContext.Quizzes
                .Include(q => q.Questions)
                .ThenInclude(a => a.Answers)
                .ToList();
        }

        public Quiz GetById(int id)
        {
            return ListAllQuizzes()
                .Where(i => i.QuizId == id)
                .FirstOrDefault();
        }

    }      
}

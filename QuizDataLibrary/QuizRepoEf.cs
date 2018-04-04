using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizDataLibrary
{
    class QuizRepoEf : IQuiz
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

        public Quiz GetById(int id)
        {
            return _dbContext.Quizzes.Find(id);    
        }

        public void EditQuiz(Quiz editQuiz)
        {
            _dbContext.Entry(editQuiz).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();

        }

        public void DeleteQuiz(Quiz deleteQuiz)
        {
            _dbContext.Quizzes.Remove(deleteQuiz);
            _dbContext.SaveChanges();
        }


        public List<Quiz> List()
        {
            return _dbContext.Quizzes
                .ToList();
        }
    }      
}

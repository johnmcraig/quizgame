using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizDataLibrary
{
    class QuizRepo : IQuiz
    {
        private readonly QuizTakerDbContext _dbContext;

        public List<Answer> Answers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public QuizRepo(QuizTakerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddQuiz(Quiz addQuiz)
        {
            _dbContext.Quizzes.Add(addQuiz);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Quiz> GetAll()
        {
            return _dbContext.Quizzes
                .ToList();
        }

        public Quiz GetById(int id)
        {
            return GetAll()
                .Where(i => i.QuizId == id)
                .FirstOrDefault();
        }

        public void EditQuiz(Quiz editQuiz)
        {

        }

        public void DeleteQuiz(Quiz deleteQuiz)
        {

        }
    }      
}

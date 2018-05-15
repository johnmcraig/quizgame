using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataLibrary
{
    public interface IQuiz
    {
        
        Quiz GetById(int id);

        List<Quiz> ListAllQuizzes();

        Task<Quiz> AddQuiz(Quiz newQuiz);

        void EditQuiz(Quiz editQuiz);

        void DeleteQuiz(int id);
    }
}

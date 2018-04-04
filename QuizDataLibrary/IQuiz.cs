using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataLibrary
{
    public interface IQuiz
    {
        IEnumerable<Quiz> GetAll();
        
        Quiz GetById(int id);

        List<Quiz> List();

        void AddQuiz(Quiz addQuiz);
        void EditQuiz(Quiz editQuiz);
        void DeleteQuiz(Quiz deleteQuiz);
    }
}

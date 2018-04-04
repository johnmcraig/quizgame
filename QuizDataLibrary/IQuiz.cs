using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataLibrary
{
    public interface IQuiz
    {
        
        Quiz GetById(int id);

        List<Quiz> List();

        Quiz AddQuiz(Quiz newQuiz);

        void EditQuiz(Quiz editQuiz);

        void DeleteQuiz(Quiz deleteQuiz);
    }
}

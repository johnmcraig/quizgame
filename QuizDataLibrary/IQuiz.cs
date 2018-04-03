using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataLibrary
{
    public interface IQuiz
    {
        IEnumerable<Quiz> GetAll();
        
        Quiz GetById(int id);
        
        List<Answer> Answers { get; set; }

        void AddQuiz(Quiz addQuiz);
        void EditQuiz(Quiz editQuiz);
        void DeleteQuiz(Quiz deleteQuiz);
    }
}

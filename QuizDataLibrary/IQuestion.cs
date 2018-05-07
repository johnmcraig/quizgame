using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataLibrary
{
    public interface IQuestion
    {
        Question AddQuestion(Question newQuestion);

        void DeleteQuestion(int id);

        void EditQuestion(Question editQuestion);

        List<Question> ListAllQuestions();

        Question GetById(int id);
    }
}

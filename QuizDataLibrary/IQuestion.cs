using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataLibrary
{
    public interface IQuestion
    {
        Question AddQuestion(Question newQuestion);

        void DeleteQuestion(Question deleteQuestion);

        void EditQuestion(Question editQuestion);

        List<Question> List();

        Question GetById(int id);
    }
}

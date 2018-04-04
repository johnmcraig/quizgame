using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataLibrary
{
    public interface IAnswer
    {

        void AddAnswer(Answer newAnswer);

        Answer GetById(int id);

        List<Answer> List();

        void DeleteAnswer(Answer deleteAnswer);

        void EditAnswer(Answer editAnswer);

        
    }
}

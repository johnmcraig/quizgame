using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataLibrary
{
    public interface IAnswer
    {

        Answer AddAnswer(Answer newAnswer);

        Answer GetById(int id);

        List<Answer> ListAllAnswers();

        void DeleteAnswer(int id); //Answer deleteAnswer

        void EditAnswer(Answer editAnswer);

        
    }
}

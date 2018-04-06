using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace QuizDataLibrary
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Answers { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }

    }
}

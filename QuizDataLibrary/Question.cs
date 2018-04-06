using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataLibrary
{
    public class Question
    {
        public int QuestionId { get; set; }
        
        public string Questions { get; set; }

        public List<Answer> Answers { get; set; }
    }
}

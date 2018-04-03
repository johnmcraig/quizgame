using System;
using System.Collections.Generic;
using System.Text;

namespace QuizDataLibrary
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        public string Content { get; set; }

        public List<Answer> Answers { get; set; }
    }
}

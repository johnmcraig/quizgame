using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace QuizDataLibrary
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        [JsonIgnore]
        public Quiz Quiz { get; set; } //link back to the questions to refere to the questions are attached to
        public string Content { get; set; }

        public List<Answer> Answers { get; set; }
    }
}

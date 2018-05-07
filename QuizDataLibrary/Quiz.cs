using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuizDataLibrary
{
    public class Quiz
    {
        public Quiz()
        {
            Questions = new List<Question>();
            //Answers = new List<Answer>();
        }

        public int QuizId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public List<Question> Questions { get; set; }
        //public List<Answer> Answers { get; set; }
        
    }
}

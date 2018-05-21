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
        }

        public int QuizId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public List<Question> Questions { get; set; }
    }
}

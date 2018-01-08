using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuizTaker.ViewModel
{
    [JsonObject(MemberSerialization.OptOut)]
    public class QuizViewModel
    {
        public QuizViewModel()
        {

        }

        public int Id{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }

    }
}

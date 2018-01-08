using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizTaker.Data.Models
{
    public class Quiz
    {
        public Quiz()
        {

        }
        [Key]
        [Required]
        public int Id { get; set; }

    }
}

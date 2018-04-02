using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizDataLibrary;

namespace QuizTaker.Data
{
    public class QuizTakerDbContext : DbContext
    {
        public QuizTakerDbContext(DbContextOptions<QuizTakerDbContext> options)
          : base(options)
        {
        }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using QuizDataLibrary;

namespace QuizDataLibrary
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

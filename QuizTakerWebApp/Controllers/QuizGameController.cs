using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizDataLibrary;

namespace QuizTaker.Controllers
{
    [Produces("application/json")]
    [Route("api/QuizGame")]
    public class QuizGameController : Controller
    {
        private readonly IQuiz _quizRepo;
        private readonly IAnswer _answerRepo;
        private readonly IQuestion _questionRepo;
        private readonly QuizTakerDbContext _dbContext;

        public QuizGameController(IQuiz quizRepo, IAnswer answerRepo, IQuestion questionRepo, QuizTakerDbContext dbContext)
        {
            _questionRepo = questionRepo;
            _answerRepo = answerRepo;
            _quizRepo = quizRepo;
            _dbContext = dbContext;
        }

        // GET: api/QuizGame
        [HttpGet]
        public async Task<IActionResult> GetQuizzes()  //was IEnumerable<string> Get()
        {
            var quizzes = await _dbContext.Quizzes.ToListAsync();
            var questions = await _dbContext.Questions.ToListAsync();
            var answers = await _dbContext.Answers.ToListAsync();

            return Ok(quizzes);
        }


        // GET: api/QuizGame/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetQuiz(int id) //was Quiz Get(int id)
        {
            var quiz = await _dbContext.Quizzes.FirstOrDefaultAsync(q => q.QuizId == id);
            var answer = await _dbContext.Answers.FirstOrDefaultAsync(a => a.AnswerId == id);
            var question = await _dbContext.Questions.FirstOrDefaultAsync(x => x.QuestionId == id);

            return Ok(quiz);
            //return _quizRepo.GetById(id);
        }
        
        // POST: api/QuizGame
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/QuizGame/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

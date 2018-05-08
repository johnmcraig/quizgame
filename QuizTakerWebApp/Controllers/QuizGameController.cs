using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetQuizzes(int id)  //was IEnumerable<string> Get()
        {
            var quizzes = _dbContext.Quizzes.ToList();
            var questions = _dbContext.Questions.ToList();
            var answers = _dbContext.Answers.ToList();

            return Ok(quizzes);
        }


        // GET: api/QuizGame/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetQuiz(int id) //was Quiz Get(int id)
        {
            var quiz = _dbContext.Quizzes.FirstOrDefault(q => q.QuizId == id);

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

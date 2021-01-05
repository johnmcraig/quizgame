using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuizDataLibrary;

namespace QuizTaker.Controllers
{
    [Produces("application/json")]
    [Route("api/QuizGame")]
    public class QuizGameController : Controller
    {
        private readonly IQuiz _quizRepo;
        private readonly QuizTakerDbContext _dbContext;
        private readonly ILogger<QuizGameController> _logger;

        public QuizGameController(IQuiz quizRepo, QuizTakerDbContext dbContext, ILogger<QuizGameController> logger)
        {
            _quizRepo = quizRepo;
            _dbContext = dbContext;
            _logger = logger;
        }

        // GET: api/QuizGame
        [HttpGet]
        public async Task<IActionResult> GetQuizzes()
        {
            var quizzes = await _dbContext.Quizzes
                .Include(q => q.Questions)
                .ThenInclude(a => a.Answers)
                .ToListAsync();
     
            try
            {
                return Ok(_quizRepo.ListAllQuizzes());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to find quiz: {ex}");
                return BadRequest("Failed to get quiz");
            }
            
        }


        // GET: api/QuizGame/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetQuiz(int id)
        {
            var quiz = await _dbContext.Quizzes
                .FirstOrDefaultAsync(q => q.QuizId == id);

            try
            {
                return Ok(quiz);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to find quiz: {ex}");
                return BadRequest("Failed to get quiz");
            }
        }
        
        // POST: api/QuizGame
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Quiz newQuiz)
        {
            try
            {
                await _quizRepo.AddQuiz(newQuiz);
                return Created($"api/QuizGame/{newQuiz.QuizId}", newQuiz);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to post a quiz: {ex}");
                return BadRequest("Failed to post a quiz");
            }
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

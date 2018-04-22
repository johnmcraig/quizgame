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

        public QuizGameController(IQuiz quizRepo)
        {
            _quizRepo = quizRepo;
        }

        // GET: api/QuizGame
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/QuizGame/5
        [HttpGet("{id}", Name = "Get")]
        public Quiz Get(int id)
        {
            return _quizRepo.GetById(id);
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

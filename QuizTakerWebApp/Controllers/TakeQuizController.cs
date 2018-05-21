using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizDataLibrary;

namespace QuizTaker.Controllers
{
    [Authorize]
    public class TakeQuizController : Controller
    {
        private readonly IQuiz _quizRepo;

        public TakeQuizController(IQuiz quizRepo)
        {
            _quizRepo = quizRepo;
        }

        // GET: TakeQuiz
        public ActionResult Index()
        {
            return View();
        }

    }
}
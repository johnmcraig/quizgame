using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizDataLibrary;

namespace QuizTaker.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        private readonly IQuiz _quizRepo;
        private readonly ILogger<QuizController> _logger;

        public QuizController(IQuiz quizRepo, ILogger<QuizController> logger)
        {
            _quizRepo = quizRepo;
            _logger = logger;
        }

        // GET: Quiz
        public ActionResult Index()
        {
            var quiz = _quizRepo.ListAllQuizzes();
            return View(_quizRepo.ListAllQuizzes());
        }

        // GET: Quiz/Details/5
        public ActionResult Details(int id)
        {
            return View(_quizRepo.GetById(id));
        }

        // GET: Quiz/Create
        public ActionResult Create()
        {
            Quiz newQuiz = new Quiz
            {
                PublishDate = DateTime.Now 
            };

            return View(newQuiz);
        }

        // POST: Quiz/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Quiz newQuiz, IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here 
                if (ModelState.IsValid)
                {
                    _quizRepo.AddQuiz(newQuiz);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to create a quiz: {ex}");
                return View(newQuiz);
            }
        }

        // GET: Quiz/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_quizRepo.GetById(id));
        }

        // POST: Quiz/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Quiz editQuiz, IFormCollection collection)
        {
            try
            {
                _quizRepo.EditQuiz(editQuiz);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to edit a question: {ex}");
                return View(editQuiz);
            }
        }

        // GET: Quiz/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_quizRepo.GetById(id));
        }

        // POST: Quiz/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Quiz deleteQuiz, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _quizRepo.DeleteQuiz(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to delete a quiz: {ex}");

                return View();
            }
        }
    }
}
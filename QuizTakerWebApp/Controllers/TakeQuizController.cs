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

        // GET: TakeQuiz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TakeQuiz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TakeQuiz/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TakeQuiz/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TakeQuiz/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TakeQuiz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TakeQuiz/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizDataLibrary;

namespace QuizTaker.Controllers
{
    public class AnswerController : Controller
    {
        private readonly IAnswer _answerRepo; 
        
        public AnswerController(IAnswer answerRepo)
        {
            _answerRepo = answerRepo;
        }

        // GET: Answer
        public ActionResult Index()
        {
            var answer = _answerRepo.ListAllAnswers();
            return View(_answerRepo.ListAllAnswers());
        }

        // GET: Answer/Details/5
        public ActionResult Details(int id)
        {
            return View(_answerRepo.GetById(id));
        }

        // GET: Answer/Create
        public ActionResult Create()
        {
            Answer newAnswer = new Answer();

            return View(newAnswer);
        }

        // POST: Answer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Answer newAnswer, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _answerRepo.AddAnswer(newAnswer);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(newAnswer);
            }
        }

        // GET: Answer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Answer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Answer editAnswer, IFormCollection collection)
        {
            try
            {
                _answerRepo.EditAnswer(editAnswer);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(editAnswer);
            }
        }

        // GET: Answer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Answer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Answer deleteAnswer, IFormCollection collection)
        {
            try
            {
                
                _answerRepo.DeleteAnswer(deleteAnswer);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
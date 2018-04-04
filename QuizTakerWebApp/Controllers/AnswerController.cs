using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuizTaker.Controllers
{
    public class AnswerController : Controller
    {
        // GET: Answer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Answer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Answer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Answer/Create
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

        // GET: Answer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Answer/Edit/5
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

        // GET: Answer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Answer/Delete/5
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
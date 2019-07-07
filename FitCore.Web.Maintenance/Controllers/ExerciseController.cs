using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitCore.Model.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitCore.Web.Maintenance.Controllers
{
    public class ExerciseController : Controller
    {
        //[Authorize]
        public async Task<ActionResult> AddToWorkout(int id)
        {
            // get the user
            // get the workout??           
            var exercise = await _repo.GetExerciseDetailsAsync(id);
            return await Task.FromResult(View(exercise));
        }

        private readonly IRepository _repo;
        public ExerciseController(IRepository repo)
        {
            _repo = repo;
        }
        // GET: Exercise
        public async Task<ActionResult> Index()
        {
            return View(await _repo.GetAllExercisesAsync());
        }

        // GET: Exercise/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Exercise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exercise/Create
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

        // GET: Exercise/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Exercise/Edit/5
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

        // GET: Exercise/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Exercise/Delete/5
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
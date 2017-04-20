using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningSystem.Models.View.Course;
using LearningSystem.Services;


namespace LearningSystem.Web.Controllers
{
    public class CourseController : Controller
    {
        public CourseService Service { get; }

        public CourseController()
        {
            this.Service =new CourseService();
        }
        // GET: Course
        public ActionResult Index()
        {
            var model = Service.GetAllCourses();
            return View();
        }

       
        public ActionResult Signin(string name)
        {
            this.Service.SignStudentToCourse(name);
            return RedirectToAction("Index");
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create( CreateVM model)
        {
            if (ModelState.IsValid)
            {
               Service.Create(model);
                return RedirectToAction("Index","Home")
   ;         }
            return this.View();
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

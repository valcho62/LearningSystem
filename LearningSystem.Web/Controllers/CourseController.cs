using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningSystem.Models.View.Course;
using LearningSystem.Services;


namespace LearningSystem.Web.Controllers
{
    [RoutePrefix("course")]
    [Authorize]
    public class CourseController : Controller
    {
        public CourseService Service { get; }

        public CourseController()
        {
            this.Service =new CourseService();
        }
        // GET: Course
        [AllowAnonymous]
        public ActionResult Index()
        {
            var model = Service.GetAllCourses();
            return View(model);
        }


       
        [Route ("signin/{name}")]
        public ActionResult Signin(string name)
        {
            var user = User.Identity.Name;
            this.Service.SignStudentToCourse(name,user);
            return RedirectToAction("Index");
        }

        [Route("signout/{name}")]
        public ActionResult Signout(string name)
        {
            var user = User.Identity.Name;
            this.Service.SignOutStudentFromCourse(name, user);
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

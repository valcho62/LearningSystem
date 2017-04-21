using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningSystem.Services;
using LearningSystem.Web.Attributes;

namespace LearningSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeService Service { get; set; }

        public HomeController()
        {
            this.Service =new HomeService();
        }
        public ActionResult Index()
        {

            return RedirectToAction("Index", "Course");
        }

        [MyAuthorize (Roles = "Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
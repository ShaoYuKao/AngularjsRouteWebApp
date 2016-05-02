using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularjsRouteWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NgRoute()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

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

        [HttpPost]
        public ActionResult GetJson()
        {
            Person person = new Person();
            person.Name = "Kitty";
            person.Age = 18;

            return Json(person);
        }

        public ActionResult SendMessage()
        {
            return View();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
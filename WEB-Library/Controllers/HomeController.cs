using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_Library.Models;

namespace WEB_Library.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Donation()
        {

            return View();
        }
        public ActionResult AdminPage()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Message = "Your application description page.";

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
    }

    public class BookController : Controller
    {
        public ActionResult GetBook()
        {
            var book = new Book { Title = "ASP.NET MVC Guide" };
            return Json(new { title = book.Title }, JsonRequestBehavior.AllowGet);
        }
    }
}
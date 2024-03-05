using Newtonsoft.Json;
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
        public ActionResult Search(string query)
        {
            
            var bookInfo = new
            {
                title = "Название книги: " + query,
                imageUrl = Url.Content("~/Images/2.jpg")
            };
            return Content(JsonConvert.SerializeObject(bookInfo), "application/json");
        }
    }
}
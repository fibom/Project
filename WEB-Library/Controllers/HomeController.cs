using WEB_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB_Library.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Book> books = db.Books;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = books;
            // возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }


        public ActionResult AdminPage()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult Shop()
        {

            return View();
        }
        public ActionResult LoginPage()
        {

            return View();
        }
        public ActionResult Registration()
        {

            return View();
        }
        public ActionResult Donation()
        {

            // получаем из бд все объекты Book
            IEnumerable<Libraries> bookss = db.Library;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Library = bookss;
            // возвращаем представление

            return View();
        }
        /*public ActionResult Donation()
        {

            // получаем из бд все объекты Book
            IEnumerable<Book> bookss = db.Books;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = bookss;
            // возвращаем представление

            return View();
        }*/





    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_Library.Models;

namespace WebApplication1.Controllers
{
    public class AccessController : Controller
    {
        private LibraryDbContext db = new LibraryDbContext();

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(string name, string password)
        {
            var person = db.People.FirstOrDefault(p => p.Name == name && p.Password == password);
            if (person != null)
            {
                return RedirectToAction("AdminPage");
            }
            else
            {
                ModelState.AddModelError("", "Incorrect name or password");
                return View();
            }
        }

        public ActionResult AdminPage()
        {
            return View();
        }
    }
}
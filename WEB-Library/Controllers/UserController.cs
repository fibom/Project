using WEB_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB_Library.Controllers
{
    public class UserController : Controller
    {
        private UserContext db = new UserContext();

        // GET: /User/Add
        public ActionResult Add()
        {
            return View();
        }

        // POST: /User/Add
        [HttpPost]
        public ActionResult Add(User newUser)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(newUser);
                db.SaveChanges();
                return RedirectToAction("Contact", "Home");
            }

            return View(newUser);
        }
    }
}
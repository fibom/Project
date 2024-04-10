using WEB_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB_Library.Controllers
{
    public class ReadController : Controller
    {
        private ReadContext db = new ReadContext();

        // GET: /User/Add
        public ActionResult Add()
        {
            return View();
        }

        // POST: /User/Add
        [HttpPost]
        public ActionResult Add(Read newRead)
        {
            if (ModelState.IsValid)
            {
                db.Reads.Add(newRead);
                db.SaveChanges();
                return RedirectToAction("Donation", "Home");
            }

            return View(newRead);
        }
    }
}
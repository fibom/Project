using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_Library.Models;

namespace WEB_Library.Controllers
{
    
    
        public class AccountController : Controller
        {
            private AccountContext db = new AccountContext();

            // GET: Account/Register
            [HttpGet]
            public ActionResult Registr()
            {
                return View();
            }

            public ActionResult Login()
            {
                return View();
            }

            // POST: Account/Register
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Registr(RegisterViewModel model)
            {
                if (ModelState.IsValid)
                {
                    var account = new Account { Username = model.Email, Password = model.Password };
                    db.Account.Add(account);
                    db.SaveChanges();

                    // Optionally, log the user in after registration
                    // FormsAuthentication.SetAuthCookie(user.Username, false);

                    return RedirectToAction("Index", "Home");
                }

                return View(model);
            }
        }
    }

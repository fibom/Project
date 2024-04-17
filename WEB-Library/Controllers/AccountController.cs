using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB_Library.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Login(string first, string password)
        {
            // Проверка логина и пароля, обработка входа
            return RedirectToAction("Index", "Home"); // Перенаправление после успешного входа
        }
    }
}
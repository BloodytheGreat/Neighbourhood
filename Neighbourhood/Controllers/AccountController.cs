using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Neighbourhood.Models;
using System.Data.Entity;


namespace Neighbourhood.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(Account account)
        {
            if (ModelState.IsValid)
            {
                using (AccDbcontext db = new AccDbcontext())
                {
                    db.acc.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = "Registratition complete";
            }
            return RedirectToAction("Login");
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Account user)
        {
            using (AccDbcontext db = new AccDbcontext())
            {
                var usr = db.acc.FirstOrDefault(u => u.user_Email == user.user_Email && u.password == user.password);
                if (usr != null)
                {
                    Session["user_id"] = usr.user_id.ToString();
                    Session["user_Email"] = usr.user_Email.ToString();
                    return RedirectToAction("MainTaskPage", "Task", new { area = "Task" });
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is wrong!");
                }
                return View();
            }
        }


	}
}
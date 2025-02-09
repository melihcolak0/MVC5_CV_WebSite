using _41MY_MVCWebSiteCV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace _41MY_MVCWebSiteCV.Controllers
{
    [AllowAnonymous]
    public class LogInController : Controller
    {
        // GET: LogIn

        Entities dataBase = new Entities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Tbl_Users p)
        {
            var value = dataBase.Tbl_Users.
                FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if(value != null)
            {
                FormsAuthentication.SetAuthCookie(value.UserName, false);
                Session["UserName"] = value.UserName.ToString();
                return RedirectToAction("Index", "AboutMe");
            }
            else
            {
                return RedirectToAction("Index", "LogIn");
            }           
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "LogIn");
        }
    }
}


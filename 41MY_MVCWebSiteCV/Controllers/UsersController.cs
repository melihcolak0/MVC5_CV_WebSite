using _41MY_MVCWebSiteCV.Models.Entity;
using _41MY_MVCWebSiteCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users

        UsersRepository repository = new UsersRepository();

        public ActionResult Index()
        {
            var user = repository.List();
            return View(user);
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(Tbl_Users p)
        {
            repository.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteUser(int id)
        {
            Tbl_Users e = repository.Find(x => x.Id == id);
            repository.TDelete(e);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetUser(int id)
        {
            Tbl_Users e = repository.Find(x => x.Id == id);
            return View(e);
        }

        [HttpPost]
        public ActionResult GetUser(Tbl_Users p)
        {
            Tbl_Users e = repository.Find(x => x.Id == p.Id);
            e.UserName = p.UserName;
            e.Password = p.Password;            
            repository.TUpdate(e);
            return RedirectToAction("Index");
        }
    }
}

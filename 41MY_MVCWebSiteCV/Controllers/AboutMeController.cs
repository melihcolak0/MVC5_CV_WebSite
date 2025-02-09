using _41MY_MVCWebSiteCV.Models.Entity;
using _41MY_MVCWebSiteCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV.Controllers
{
    public class AboutMeController : Controller
    {
        // GET: AboutMe

        AboutMeRepository repository = new AboutMeRepository();

        [HttpGet]
        public ActionResult Index()
        {
            var values = repository.List();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(Tbl_AboutMe p)
        {
            var value = repository.Find(x => x.Id == 1);
            value.Name = p.Name;
            value.Surname = p.Surname;
            value.Address = p.Address;
            value.PhoneNumber = p.PhoneNumber;
            value.EMail = p.EMail;
            value.Description = p.Description;
            value.Image = p.Image;
            repository.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
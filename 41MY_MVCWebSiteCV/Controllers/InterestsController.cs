using _41MY_MVCWebSiteCV.Models.Entity;
using _41MY_MVCWebSiteCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV.Controllers
{
    public class InterestsController : Controller
    {
        // GET: Interests

        InterestsRepository repository = new InterestsRepository();

        [HttpGet]
        public ActionResult Index()
        {
            var interest = repository.List();
            return View(interest);
        }

        [HttpPost]
        public ActionResult Index(Tbl_Interests p)
        {
            var interest = repository.Find(x => x.Id == 2);
            interest.Description = p.Description;
            interest.Description2 = p.Description2;
            repository.TUpdate(interest);
            return RedirectToAction("Index");
        }
    }
}


using _41MY_MVCWebSiteCV.Models.Entity;
using _41MY_MVCWebSiteCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV.Controllers
{
    public class ExperiencesController : Controller
    {
        // GET: Experiences

        ExperiencesRepository repository = new ExperiencesRepository();

        public ActionResult Index()
        {
            var values = repository.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(Tbl_Experiences p)
        {
            repository.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            Tbl_Experiences e = repository.Find(x => x.Id == id);
            repository.TDelete(e);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetExperience(int id)
        {
            Tbl_Experiences e = repository.Find(x => x.Id == id);
            return View(e);
        }

        [HttpPost]
        public ActionResult GetExperience(Tbl_Experiences p)
        {
            Tbl_Experiences e = repository.Find(x => x.Id == p.Id);
            e.Title = p.Title;
            e.SubHeading = p.SubHeading;
            e.Description = p.Description;
            e.Date = p.Date;
            repository.TUpdate(e);
            return RedirectToAction("Index");            
        }
    }
}

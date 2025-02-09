using _41MY_MVCWebSiteCV.Models.Entity;
using _41MY_MVCWebSiteCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV.Controllers
{
    public class EducationsController : Controller
    {
        // GET: Educations

        EducationsRepository repository = new EducationsRepository();
        
        public ActionResult Index()
        {
            var values = repository.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(Tbl_Education p)
        {
            if(!ModelState.IsValid)
            {
                return View("AddEducation");
            }
            repository.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var education = repository.Find(x => x.Id == id);
            repository.TDelete(education);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetEducation(int id)
        {
            var education = repository.Find(x => x.Id == id);
            return View(education);
        }

        [HttpPost]
        public ActionResult GetEducation(Tbl_Education p)
        {
            if (!ModelState.IsValid)
            {
                return View("GetEducation");
            }

            var education = repository.Find(x => x.Id == p.Id);
            education.Title = p.Title;
            education.SubHeading = p.SubHeading;
            education.SubHeading2 = p.SubHeading2;
            education.GPA = p.GPA;
            education.Date = p.Date;
            repository.TUpdate(education);
            return RedirectToAction("Index");
        }
    }
}


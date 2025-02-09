using _41MY_MVCWebSiteCV.Models.Entity;
using _41MY_MVCWebSiteCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV.Controllers
{
    public class AbilitiesController : Controller
    {
        // GET: Abilities

        AbilitiesRepository repository = new AbilitiesRepository();        

        public ActionResult Index()
        {
            var abilities = repository.List();
            return View(abilities);
        }

        [HttpGet]
        public ActionResult AddAbility()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbility(Tbl_Abilities p)
        {
            repository.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAbility(int id)
        {
            var ability = repository.Find(x => x.Id == id);
            repository.TDelete(ability);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetAbility(int id)
        {
            Tbl_Abilities a = repository.Find(x => x.Id == id);
            return View(a);
        }

        [HttpPost]
        public ActionResult GetAbility(Tbl_Abilities p)
        {
            Tbl_Abilities a = repository.Find(x => x.Id == p.Id);
            a.Ability = p.Ability;
            a.Rate = p.Rate;            
            repository.TUpdate(a);
            return RedirectToAction("Index");
        }
    }
}


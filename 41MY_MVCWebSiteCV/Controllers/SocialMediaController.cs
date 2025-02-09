using _41MY_MVCWebSiteCV.Models.Entity;
using _41MY_MVCWebSiteCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia

        SocialMediaRepository repository = new SocialMediaRepository();

        public ActionResult Index()
        {
            var values = repository.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSocialMedia(Tbl_SocialMedia p)
        {
            repository.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetSocialMedia(int id)
        {
            var acc = repository.Find(x => x.Id == id);
            return View(acc);
        }

        [HttpPost]
        public ActionResult GetSocialMedia(Tbl_SocialMedia p)
        {
            var acc = repository.Find(x => x.Id == p.Id);
            acc.Name = p.Name;
            acc.Link = p.Link;
            acc.Icon = p.Icon;
            acc.State = true;
            repository.TUpdate(acc);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var acc = repository.Find(x => x.Id == id);
            acc.State = false;
            repository.TUpdate(acc);
            return RedirectToAction("Index");
        }
    }
}

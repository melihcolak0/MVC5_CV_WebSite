using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _41MY_MVCWebSiteCV.Models.Entity;

namespace _41MY_MVCWebSiteCV.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default

        Entities dataBase = new Entities();

        public ActionResult Index()
        {
            var values = dataBase.Tbl_AboutMe.ToList();
            return View(values);
        }

        public PartialViewResult SocialMedia()
        {
            var socialMedia = dataBase.Tbl_SocialMedia.Where(x => x.State == true).ToList();
            return PartialView(socialMedia);
        }

        public PartialViewResult Experiences()
        {
            var experiences = dataBase.Tbl_Experiences.ToList();
            return PartialView(experiences);
        }

        public PartialViewResult Educations()
        {
            var educations = dataBase.Tbl_Education.ToList();
            return PartialView(educations);
        }

        public PartialViewResult Abilities()
        {
            var abilities = dataBase.Tbl_Abilities.ToList();
            return PartialView(abilities);
        }

        public PartialViewResult Interests()
        {
            var interests = dataBase.Tbl_Interests.ToList();
            return PartialView(interests);
        }

        public PartialViewResult Certificates()
        {
            var certificates = dataBase.Tbl_Certificates.ToList();
            return PartialView(certificates);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Contact(Tbl_Contact c)
        {
            c.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            dataBase.Tbl_Contact.Add(c);
            dataBase.SaveChanges();
            return PartialView();
        }
    }
}


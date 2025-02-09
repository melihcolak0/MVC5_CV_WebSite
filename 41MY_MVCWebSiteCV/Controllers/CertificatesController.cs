using _41MY_MVCWebSiteCV.Models.Entity;
using _41MY_MVCWebSiteCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV.Controllers
{
    public class CertificatesController : Controller
    {
        // GET: Certificates

        CertificatesRepository repository = new CertificatesRepository();

        public ActionResult Index()
        {
            var values = repository.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult GetCertificate(int id)
        {
            var certificate = repository.Find(x => x.Id == id);
            return View(certificate);
        }

        [HttpPost]
        public ActionResult GetCertificate(Tbl_Certificates p)
        {
            var certificate = repository.Find(x => x.Id == p.Id);
            certificate.Description = p.Description;
            certificate.Date = p.Date;
            repository.TUpdate(certificate);
            return RedirectToAction("Index");            
        }

        [HttpGet]
        public ActionResult AddCertificate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCertificate(Tbl_Certificates p)
        {
            repository.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCertificate(int id)
        {
            var certficate = repository.Find(x => x.Id == id);
            repository.TDelete(certficate);
            return RedirectToAction("Index");
        }
    }
}
using _41MY_MVCWebSiteCV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        ContactRepository repository = new ContactRepository();

        public ActionResult Index()
        {
            var values = repository.List();
            return View(values);
        }
    }
}
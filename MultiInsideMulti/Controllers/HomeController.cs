using MultiInsideMulti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiInsideMulti.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public void MultiContactPerson(ContactPerson contactPerson)
        {
            
        }
    }
}
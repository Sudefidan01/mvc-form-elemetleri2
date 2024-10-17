using _09122023_MvcFormElementleri2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09122023_MvcFormElementleri2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Kullanici());
        }

       
    }
}
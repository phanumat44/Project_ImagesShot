using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Images.Controllers
{
    public class NatureController : Controller
    {
        // GET: Nature
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult nature()
        {
            return View();
        }
    }
}
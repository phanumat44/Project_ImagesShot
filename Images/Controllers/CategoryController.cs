using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Images.Controllers
{
    public class CategoryController : Controller
    {
        private Entities1 db = new Entities1();
        // GET: Category
        public ActionResult Art()
        {
            return View(db.Pictures.ToList().Where(picture => picture.Type == "ศิลปะ"));
        }
        public ActionResult Nature()
        {
            return View(db.Pictures.ToList().Where(picture => picture.Type == "ธรรมชาติ"));
        }
        public ActionResult Animal()
        {
            return View(db.Pictures.ToList().Where(picture => picture.Type == "สัตว์"));
        }
        public ActionResult Science()
        {
            return View(db.Pictures.ToList().Where(picture => picture.Type == "วิทยาศาสตร์"));
        }
        public ActionResult Tech()
        {
            return View(db.Pictures.ToList().Where(picture => picture.Type == "เทคโนโลยี"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindClass.Controllers
{
    public class FooController : Controller
    {
        //
        // GET: /Foo/
        public ActionResult Lesson7()
        {
            Bar("5 Gum Peppermint");

            return View();
        }
        public ActionResult Lesson9()
        {
           

            return View();
        }
        public String Bar(String favGum)
        {
            ViewBag.favGum = favGum;

            return "";
        } 

	}
}
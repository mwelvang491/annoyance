using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindClass.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/
        public ActionResult Index(string id, string name)
        {
            ViewBag.value = id;

            return View();
        }

        public ActionResult stuff(double? id)
        {
            ViewBag.number = id;
            ViewBag.qty = 2;
            return View();
        }

        public ActionResult addnumbers()
        {

            return View();
        }

        [HttpPost]
        public ActionResult addnumbers(FormCollection form)
        {
            double num1, num2;

             
            if (Double.TryParse(form["num1"], out num1) &&
                Double.TryParse(form["num2"], out num2)  )
            {
                ViewBag.total = num1 + num2;
            }
            else
            {
                ViewBag.total = "Invalid Entry";
            }

  
            return View();
        }

        public ActionResult DisplayList()
        {
            string[] nameArray = { "joe", "Bob", "Jim", "Sue" };
            ViewBag.names = nameArray;

            return View();
        }


	}


}
using NorthwindClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindClass.Controllers
{
    public class HomeController : Controller
    {


       public ActionResult Index()
       {

           return View();
       }
        
        public ActionResult DBTest()
        {

            return View();
        }




        public ActionResult About()
        {
           
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult product(int? id)
        {
   
            return View();
        }

        public ActionResult Categories()
        {
            return View();
        }


    }
}
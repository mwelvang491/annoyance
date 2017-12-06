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
       List<Product> products = new List<Product>()
            {
             new Product { productId = 1, productName="Cheese",              productPrice = 1.19, catID=1 },
             new Product { productId = 2, productName="Luke Skywalker Doll", productPrice = 2.19, catID=2 },
             new Product { productId = 3, productName="11 Firecrackers",     productPrice = 3.19, catID=3 },
            };

       List<Category> categories = new List<Category>()
        {
         new Category { categoryId = 1, categoryName = "Food" },
         new Category { categoryId = 2, categoryName = "Tools" },
         new Category { categoryId = 3, categoryName = "Toys" }
        };

       public ActionResult Index()
       {

           return View();
       }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult product(int? id)
        {
            if (id == null)
            {
                return View(products);
            }

            var results = from n in products where n.catID.Equals(id) select n;
            return View(results);
        }

        public ActionResult Categories()
        {
            return View(categories);
        }


    }
}
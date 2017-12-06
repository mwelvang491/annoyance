using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindClass.Models
{
    public class Product
    {
          public int productId { get; set; }
          public String productName  { get; set; }
          public double productPrice { get; set;}

          public int catID { get; set; }

    }
}
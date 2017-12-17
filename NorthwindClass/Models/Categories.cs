using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindClass.Models
{
    public class Categories
    {
        //this data is from a different table.
        //and goes on the left of the page
        public string Category { get; set; }
        //this data is also from a different table.
        //and goes on the center of the page
        public List<Product> Products { get; set; }
    }
}
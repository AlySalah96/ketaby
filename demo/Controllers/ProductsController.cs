using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    [RoutePrefix("Products")]
    public class ProductsController : Controller
    {
       
        public ViewResult Index()
        {
           
            return View(); 
          
        }

        [Route("{Category}")]
        public string showcategory(string Category)
        {
            return "this is products in category :" + Category;
        }

        [Route("{Category}/{id:int}")]
        public string categoryDetails(string Category, int id)
        {

            return "this is indidual category  :" + Category + "there is product with id " + id;
        }



        [Route("~/for-sale/{Category?}")]
        public string sale(string Category)
        {
            return "there items for sale " + Category;
        }










    }
}
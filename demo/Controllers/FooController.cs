using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class FooController : Controller
    {
        // GET: Foo
        //[NonAction]
        public string Index(string id)
        {
            return "this is index method on foo controller";
        }
    }
}
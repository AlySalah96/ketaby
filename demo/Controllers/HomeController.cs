﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       //[NonAction]
        public string Index(string id)
        {
            return "this home controller: "+id;
        }
    }
}
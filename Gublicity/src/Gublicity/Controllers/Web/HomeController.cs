﻿using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gublicity.Controllers.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult About_Us()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Contact_Us()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
    }
}

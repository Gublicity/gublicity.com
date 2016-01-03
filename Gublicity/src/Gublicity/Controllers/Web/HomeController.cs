using Gublicity.Models;
using Gublicity.ViewModels;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gublicity.Controllers.Web
{
    public class HomeController : Controller
    {
        private IGublicityRepository __repository;

        public HomeController( IGublicityRepository repository)
        {
            __repository = repository;
        }
        public IActionResult Index()
        {
            var Administrators = __repository.getAllAdministrators();
            
            return View(Administrators);
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

        [HttpPost]
        public IActionResult Contact_Us(ContactViewModel model)
        {
            var email = Startup.Configuration["AppSettings:SiteEmailAddress"];

            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
    }
}

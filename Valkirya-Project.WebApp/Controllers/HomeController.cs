using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Valkirya_Project.WebApp.Models;

namespace Valkirya_Project.WebApp.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        [HttpPost]
        [Route("Home/Index")]
        public IActionResult Index(ProfileViewModel profile)
        {
            return View();
        }

        [HttpPost]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login() => View();

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(ProfileViewModel profile)
        {
            if (!ModelState.IsValid) {
                return View("Index");
            }

            return View();
        }
    }
}

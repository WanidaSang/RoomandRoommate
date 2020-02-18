using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoomandRoommatematching.Models;

namespace RoomandRoommatematching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(String Username, String Password)
        {
            if (Username == "admin" && Password == "admin")
            {
                return RedirectToAction("SearchDormitory", "Admin");
            } else if (Username == "roommate1" && Password == "roommate1")
            {
                return RedirectToAction("", "Roommate");
            } else if (Username == "joinroommate1" && Password == "joinroommate1")
            {
                return RedirectToAction("", "JoinRoommate");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Informations()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

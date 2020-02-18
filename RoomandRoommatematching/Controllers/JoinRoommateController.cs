using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoomandRoommatematching.Controllers
{
    public class JoinRoommateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowMatchRoommate()
        {
            return View();
        }

        public IActionResult Individualdetails()
        {
            return View();
        }

        public IActionResult CancelJoin()
        {
            return View();
        }

        public IActionResult DetailCancelJoin()
        {
            return View();
        }
    }
}
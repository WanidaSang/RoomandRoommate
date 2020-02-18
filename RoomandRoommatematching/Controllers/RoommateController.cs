using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoomandRoommatematching.Controllers
{
    public class RoommateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JoinToMe()
        {
            return View();
        }

        public IActionResult DetailJoinToMe()
        {
            return View();
        }

        public IActionResult ShowDetailMeaftersave()
        {
            return View();
        }

        public IActionResult DetailShowDetailMeaftersave()
        {
            return View();
        }
    }
}
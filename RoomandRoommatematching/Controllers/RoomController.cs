﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoomandRoommatematching.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DetailRoom()
        {
            return View();
        }

        public IActionResult SearchRoom()
        {
            return View();
        }
    }
}
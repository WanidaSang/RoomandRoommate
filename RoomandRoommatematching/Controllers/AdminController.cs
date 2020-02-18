using Microsoft.AspNetCore.Mvc;
using RoomandRoommatematching.Models;
using System;
using System.Data;
using System.Linq;

namespace RoomandRoommatematching.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNew(String name_dormitory, String address_dormitory , float price_dormitory ,int telephone_dormitory 
            ,int elecbill_dormitory , int waterbill_dormitory , String email_dormitory , int insurancefree_dormitory , String facilities_dormitory
            , String gender_dormitory , int people_dormitory , String animal_dormitory, String smoke_dormitory
            ,String door1win_dormitory , String door1walk_dormitory , String door2win_dormitory, String door2walk_dormitory )

        {
            dormitoryModel dorm = new dormitoryModel();
            dorm.name_dormitory = name_dormitory;
            dorm.address_dormitory = address_dormitory;
            dorm.price_dormitory = price_dormitory;
            dorm.telephone_dormitory = telephone_dormitory;

            dorm.elecbill_dormitory = elecbill_dormitory;
            dorm.waterbill_dormitory = waterbill_dormitory;
            dorm.email_dormitory = email_dormitory;
            dorm.insurancefree_dormitory = insurancefree_dormitory;

            dorm.facilities_dormitory = facilities_dormitory;

            dorm.gender_dormitory = gender_dormitory;
            dorm.people_dormitory = people_dormitory;
            dorm.animal_dormitory = animal_dormitory;
            dorm.smoke_dormitory = smoke_dormitory;

            dorm.door1win_dormitory = door1win_dormitory;
            dorm.door1walk_dormitory = door1walk_dormitory;
            dorm.door2win_dormitory = door2win_dormitory;
            dorm.door2walk_dormitory = door2walk_dormitory;
            
            dorm.AddNew();
            return RedirectToAction("Searchdormitory", "Admin");
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult SearchDormitory()
        {
            dormitoryModel dormi = new dormitoryModel();
            ViewData.Model = dormi.getDormitoryAll("").AsEnumerable();
            return View();
        }

        public IActionResult AddDormitory()
        {
            return View();
        }
    }
}
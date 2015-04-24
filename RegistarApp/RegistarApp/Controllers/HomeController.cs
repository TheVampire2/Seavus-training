using RegistarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistarApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bike()
        {
            List<Bike> bikes = new List<Bike>();
            bikes.Add(new Bike(
                name: "BMX",
                rating: 5,
                type: "street"));
            bikes.Add(new Bike(
                name: "RoadXXX",
                rating: 4,
                type: "roadBike"));
            return View(bikes);
        }
        public JsonResult BikeRest()
        {
            List<Bike> bikes = new List<Bike>();
            bikes.Add(new Bike(
                name: "BMX",
                rating: 5, 
                type: "street"));
            bikes.Add(new Bike(
                name: "RoadXXX",
                rating: 4, 
                type: "roadBike"));
            return Json(bikes,JsonRequestBehavior.AllowGet);
        }

        

    }
}

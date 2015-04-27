using BuisnessLayer;
using BuisnessLayer.Contracts;
using DomainModel;
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
        //
        // GET me all bikes from database
        public ActionResult Bikes()
        {
            
            BikeSearchCommand _command = new BikeSearchCommand();
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);

            return View(_result.Result);
        }
        
        /// <summary>
        /// Returns all bikes in Json
        /// </summary>
        /// <returns></returns>
        public JsonResult BikesRest()
        {
            
            BikeSearchCommand _command = new BikeSearchCommand();
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);

            return Json(_result,JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Search bikes that returns json result
        /// </summary>
        /// <returns></returns>
         public JsonResult SearchRest()
        {
           BikeSearchCommand _command = new BikeSearchCommand();
            //some random reg number obtained from search bar
            _command.RegNum = 1123;
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand, BikeSearchResult>(_command);
            return Json(_result.Result, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// Add bike in database and return added bike in json
        /// </summary>
        /// <returns></returns>
         public JsonResult AddBikeRest()
         {
             BikeAddCommand _command = new BikeAddCommand();
             _command.City = "Kumanovo";
             _command.RegNum = 1123;
             _command.ProduceDate = DateTime.Now;
             _command.Colour = "Blue";
             _command.Type = "BMX";

             BikeAddResult _result = CommandInvoker.InvokeCommand<BikeAddCommand, BikeAddResult>(_command);
             return Json(_result.BikeAdded, JsonRequestBehavior.AllowGet);

         }

    }
}

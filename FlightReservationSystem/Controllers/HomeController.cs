using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlightReservationSystem.Models;
using Microsoft.AspNet.Identity;

namespace FlightReservationSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var currentUser = User.Identity.GetUserId();
            var PassengerInfo = db.Passengers.FirstOrDefault(d => d.ApplicationUserId == currentUser);
            if (PassengerInfo == null)
            {
                PassengerInfo = db.Passengers.Create();
                PassengerInfo.ApplicationUserId = currentUser;
                db.Passengers.Add(PassengerInfo);
                
            }

            db.SaveChanges();
            

            
            return View();
        }

        public ActionResult About()
        {

            return RedirectToAction("Index", "Flights");

        }

       
    }
}
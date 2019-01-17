using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlightReservationSystem.Models;

namespace FlightReservationSystem.Controllers
{
    public class FlightsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Flights
        public ViewResult Index(string seachString)
        {
            var query = (from f in db.Flights
                join s in db.Schedules on f.ScheduleId equals s.ScheduleId into f2
                from s in f2.DefaultIfEmpty()
                select new FlightViewModel
                {
                    FlightVM = f,
                    ScheduleVM = s
                });

            if (!String.IsNullOrEmpty(seachString))
            {
                query = query.Where(s => s.ScheduleVM.Destination.Contains(seachString));
            }

            return View(query.ToList());
        }

        

       

        // POST: Flights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "FlightId,AirlineName,FlightClass,FlightSeat,FlightPrice,TicketId,ScheduleId")] Flight flight)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Flights.Add(flight);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(flight);
        //}

      
        //// POST: Flights/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "FlightId,AirlineName,FlightClass,FlightSeat,FlightPrice,TicketId,ScheduleId")] Flight flight)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(flight).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(flight);
        //}

        //// GET: Flights/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Flight flight = db.Flights.Find(id);
        //    if (flight == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(flight);
        //}

        //// POST: Flights/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Flight flight = db.Flights.Find(id);
        //    db.Flights.Remove(flight);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

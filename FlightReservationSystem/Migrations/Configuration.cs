using System.Collections.Generic;
using System.Data.Entity.Validation;
using FlightReservationSystem.Models;

namespace FlightReservationSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FlightReservationSystem.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(FlightReservationSystem.Models.ApplicationDbContext context)
        {
            ////  This method will be called after migrating to the latest version.

            ////  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            ////  to avoid creating duplicate seed data.


            ////context.Flights.AddOrUpdate(f => f.FlightId,
            ////    new Flight
            ////    {
            ////        AirlineName = "Jet Blue",
            ////        FlightClass = "Economic",
            ////        FlightSeat = "A26",
            ////        FlightPrice = 200.00,
            ////        TicketId = 1,
            ////        ScheduleId = 1
            ////    });




            //context.Schedules.AddOrUpdate(s => s.ScheduleId,
            //    new Models.Schedule
            //    {
            //        DepartureDate = new DateTime(2018, 06, 01),
            //        DepartureTime = new TimeSpan(08, 43, 00),
            //        ArrivalDate = new DateTime(2018, 06, 01),
            //        ArrivalTime = new TimeSpan(11, 03, 00),
            //        Source = "Santo Domingo",
            //        SourceAirport = "Las Americas",
            //        SourceId = "SDQ",
            //        Destination = "New York",
            //        DestinationAirport = "JFK",
            //        DestinationId = "NY",
            //        FlightID = 1
            //    });

            //context.Tickets.AddOrUpdate(t=> t.TicketId,
            //    new Ticket
            //    {
            //        FlightId = 1, Paid = false
            //    });


            context.Configuration.ValidateOnSaveEnabled = false;

            base.Seed(context);


        }


    }


}


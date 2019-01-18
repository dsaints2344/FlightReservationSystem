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
            //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Flight', RESEED, 0)");
            //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Ticket', RESEED, 0)");
            //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Schedule', RESEED, 0)");


            ////  This method will be called after migrating to the latest version.

            ////  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            ////  to avoid creating duplicate seed data.


            //context.Flights.AddOrUpdate(f => f.FlightId,
            //    new Flight
            //    {
            //        AirlineName = "American Airlines",
            //        FlightClass = "Business",
            //        FlightSeat = "A38",
            //        FlightPrice = 268.00,
            //        TicketId = 2,
            //        ScheduleId = 2
            //    });




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
            //        Destination = "Orlando",
            //        DestinationAirport = "Orlando International",
            //        DestinationId = "FL",
            //        FlightID = 2
            //    });

            //context.Tickets.AddOrUpdate(t => t.TicketId,
            //    new Ticket
            //    {
            //        FlightId = 2,
            //        Paid = false
            //    });


            context.Configuration.ValidateOnSaveEnabled = false;

            base.Seed(context);


        }


    }


}


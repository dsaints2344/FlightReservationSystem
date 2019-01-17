namespace FlightReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BackEnd1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flight",
                c => new
                    {
                        FlightId = c.Int(nullable: false, identity: true),
                        AirlineName = c.String(),
                        FlightClass = c.String(),
                        FlightSeat = c.String(),
                        FlightPrice = c.Double(nullable: false),
                        TicketId = c.Int(nullable: false),
                        ScheduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FlightId);
            
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        RouteId = c.Int(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false),
                        DepartureTime = c.Time(nullable: false, precision: 7),
                        ArrivalTime = c.Time(nullable: false, precision: 7),
                        Flight_FlightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScheduleId)
                .ForeignKey("dbo.Flight", t => t.Flight_FlightId, cascadeDelete: true)
                .ForeignKey("dbo.Route", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.RouteId)
                .Index(t => t.Flight_FlightId);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        RouteId = c.Int(nullable: false, identity: true),
                        SourceId = c.String(),
                        Source = c.String(),
                        SourceAirport = c.String(),
                        DestinationId = c.String(),
                        Destination = c.String(),
                        DestinationAirport = c.String(),
                    })
                .PrimaryKey(t => t.RouteId);
            
            CreateTable(
                "dbo.Ticket",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        FlightId = c.Int(nullable: false),
                        PaymentId = c.Int(nullable: false),
                        PassengerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Flight", t => t.FlightId, cascadeDelete: true)
                .ForeignKey("dbo.Passenger", t => t.PassengerId)
                .Index(t => t.FlightId)
                .Index(t => t.PassengerId);
            
            CreateTable(
                "dbo.Passenger",
                c => new
                    {
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                        TicketId = c.Int(),
                    })
                .PrimaryKey(t => t.ApplicationUserId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        TicketId = c.Int(nullable: false),
                        Paid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Ticket", t => t.TicketId)
                .Index(t => t.TicketId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payment", "TicketId", "dbo.Ticket");
            DropForeignKey("dbo.Ticket", "PassengerId", "dbo.Passenger");
            DropForeignKey("dbo.Passenger", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Ticket", "FlightId", "dbo.Flight");
            DropForeignKey("dbo.Schedule", "RouteId", "dbo.Route");
            DropForeignKey("dbo.Schedule", "Flight_FlightId", "dbo.Flight");
            DropIndex("dbo.Payment", new[] { "TicketId" });
            DropIndex("dbo.Passenger", new[] { "ApplicationUserId" });
            DropIndex("dbo.Ticket", new[] { "PassengerId" });
            DropIndex("dbo.Ticket", new[] { "FlightId" });
            DropIndex("dbo.Schedule", new[] { "Flight_FlightId" });
            DropIndex("dbo.Schedule", new[] { "RouteId" });
            DropTable("dbo.Payment");
            DropTable("dbo.Passenger");
            DropTable("dbo.Ticket");
            DropTable("dbo.Route");
            DropTable("dbo.Schedule");
            DropTable("dbo.Flight");
        }
    }
}

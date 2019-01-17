namespace FlightReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedule", "RouteId", "dbo.Route");
            DropIndex("dbo.Schedule", new[] { "RouteId" });
            AddColumn("dbo.Schedule", "SourceId", c => c.String());
            AddColumn("dbo.Schedule", "Source", c => c.String());
            AddColumn("dbo.Schedule", "SourceAirport", c => c.String());
            AddColumn("dbo.Schedule", "DestinationId", c => c.String());
            AddColumn("dbo.Schedule", "Destination", c => c.String());
            AddColumn("dbo.Schedule", "DestinationAirport", c => c.String());
            DropTable("dbo.Route");
        }
        
        public override void Down()
        {
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
                        ScheduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RouteId);
            
            DropColumn("dbo.Schedule", "DestinationAirport");
            DropColumn("dbo.Schedule", "Destination");
            DropColumn("dbo.Schedule", "DestinationId");
            DropColumn("dbo.Schedule", "SourceAirport");
            DropColumn("dbo.Schedule", "Source");
            DropColumn("dbo.Schedule", "SourceId");
            CreateIndex("dbo.Schedule", "RouteId");
            AddForeignKey("dbo.Schedule", "RouteId", "dbo.Route", "RouteId", cascadeDelete: true);
        }
    }
}

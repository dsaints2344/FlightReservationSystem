namespace FlightReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Schedule", name: "Flight_FlightId", newName: "FlightID");
            RenameIndex(table: "dbo.Schedule", name: "IX_Flight_FlightId", newName: "IX_FlightID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Schedule", name: "IX_FlightID", newName: "IX_Flight_FlightId");
            RenameColumn(table: "dbo.Schedule", name: "FlightID", newName: "Flight_FlightId");
        }
    }
}

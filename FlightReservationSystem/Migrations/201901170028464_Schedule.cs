namespace FlightReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "ScheduleId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Route", "ScheduleId");
        }
    }
}

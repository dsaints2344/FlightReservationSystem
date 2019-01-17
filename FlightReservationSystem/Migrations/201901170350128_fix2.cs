namespace FlightReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Payment", name: "TicketId", newName: "PaymentId");
            RenameIndex(table: "dbo.Payment", name: "IX_TicketId", newName: "IX_PaymentId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Payment", name: "IX_PaymentId", newName: "IX_TicketId");
            RenameColumn(table: "dbo.Payment", name: "PaymentId", newName: "TicketId");
        }
    }
}

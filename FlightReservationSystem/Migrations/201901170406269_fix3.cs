namespace FlightReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payment", "PaymentId", "dbo.Ticket");
            DropIndex("dbo.Payment", new[] { "PaymentId" });
            AddColumn("dbo.Ticket", "Paid", c => c.Boolean(nullable: false));
            DropColumn("dbo.Ticket", "PaymentId");
            DropTable("dbo.Payment");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        PaymentId = c.Int(nullable: false),
                        Paid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            AddColumn("dbo.Ticket", "PaymentId", c => c.Int(nullable: false));
            DropColumn("dbo.Ticket", "Paid");
            CreateIndex("dbo.Payment", "PaymentId");
            AddForeignKey("dbo.Payment", "PaymentId", "dbo.Ticket", "TicketId");
        }
    }
}

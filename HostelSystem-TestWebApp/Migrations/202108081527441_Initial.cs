namespace HostelSystem_TestWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        PostalCode = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        CurrencyCode = c.String(nullable: false),
                        Provision = c.Int(nullable: false),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GuestReservations",
                c => new
                    {
                        Guest_ID = c.Int(nullable: false),
                        Reservation_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Guest_ID, t.Reservation_ID })
                .ForeignKey("dbo.Guests", t => t.Guest_ID, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.Reservation_ID, cascadeDelete: true)
                .Index(t => t.Guest_ID)
                .Index(t => t.Reservation_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GuestReservations", "Reservation_ID", "dbo.Reservations");
            DropForeignKey("dbo.GuestReservations", "Guest_ID", "dbo.Guests");
            DropIndex("dbo.GuestReservations", new[] { "Reservation_ID" });
            DropIndex("dbo.GuestReservations", new[] { "Guest_ID" });
            DropTable("dbo.GuestReservations");
            DropTable("dbo.Reservations");
            DropTable("dbo.Guests");
        }
    }
}

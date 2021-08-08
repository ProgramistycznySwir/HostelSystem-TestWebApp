namespace HostelSystem_TestWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Extending_Guest_model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guests", "PhoneNumber", c => c.String());
            AddColumn("dbo.Guests", "Adress", c => c.String());
            AddColumn("dbo.Guests", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Guests", "City");
            DropColumn("dbo.Guests", "Adress");
            DropColumn("dbo.Guests", "PhoneNumber");
        }
    }
}

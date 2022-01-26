namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "CategoryStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryStatus", c => c.String());
        }
    }
}

namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Viewings", "RequestedViewing", c => c.DateTime(nullable: false));
            DropColumn("dbo.Viewings", "ViewingStatus");
            DropColumn("dbo.Viewings", "DateRequested");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Viewings", "DateRequested", c => c.DateTime(nullable: false));
            AddColumn("dbo.Viewings", "ViewingStatus", c => c.Int(nullable: false));
            DropColumn("dbo.Viewings", "RequestedViewing");
        }
    }
}

namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate23 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "RequestedViewingDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Viewings", "RequestedViewingDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Viewings", "RequestedViewing");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Viewings", "RequestedViewing", c => c.DateTime(nullable: false));
            DropColumn("dbo.Viewings", "RequestedViewingDateTime");
            DropColumn("dbo.Properties", "RequestedViewingDateTime");
        }
    }
}

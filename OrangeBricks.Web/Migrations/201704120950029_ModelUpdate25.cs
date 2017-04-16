namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate25 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Viewings", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Viewings", "ViewingRequestStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Viewings", "ViewingRequestStatus", c => c.Int(nullable: false));
            DropColumn("dbo.Viewings", "Status");
        }
    }
}

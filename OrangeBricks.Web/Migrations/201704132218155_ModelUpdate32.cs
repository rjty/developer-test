namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate32 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "HasOffers", c => c.Boolean(nullable: false));
            AddColumn("dbo.Properties", "RequestedViewingDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Properties", "RequestedViewingDateTime");
            DropColumn("dbo.Properties", "HasOffers");
        }
    }
}

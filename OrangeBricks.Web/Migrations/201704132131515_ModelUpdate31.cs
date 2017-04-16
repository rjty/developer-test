namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate31 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Properties", "HasOffers");
            DropColumn("dbo.Properties", "RequestedViewingDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Properties", "RequestedViewingDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Properties", "HasOffers", c => c.Boolean(nullable: false));
        }
    }
}

namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "HasOffers", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Properties", "HasOffers");
        }
    }
}

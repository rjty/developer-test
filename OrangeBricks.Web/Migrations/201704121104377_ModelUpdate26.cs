namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate26 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Viewings");
            AddColumn("dbo.Viewings", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Viewings", "Id");
            DropColumn("dbo.Viewings", "PropertyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Viewings", "PropertyId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Viewings");
            DropColumn("dbo.Viewings", "Id");
            AddPrimaryKey("dbo.Viewings", "PropertyId");
        }
    }
}

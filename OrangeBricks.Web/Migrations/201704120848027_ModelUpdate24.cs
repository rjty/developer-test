namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate24 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Viewings", "PropertyId", "dbo.Properties");
            DropIndex("dbo.Viewings", new[] { "PropertyId" });
            DropPrimaryKey("dbo.Viewings");
            AddColumn("dbo.Viewings", "Property_Id", c => c.Int());
            AlterColumn("dbo.Viewings", "PropertyId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Viewings", "PropertyId");
            CreateIndex("dbo.Viewings", "Property_Id");
            AddForeignKey("dbo.Viewings", "Property_Id", "dbo.Properties", "Id");
            DropColumn("dbo.Viewings", "ViewingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Viewings", "ViewingId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Viewings", "Property_Id", "dbo.Properties");
            DropIndex("dbo.Viewings", new[] { "Property_Id" });
            DropPrimaryKey("dbo.Viewings");
            AlterColumn("dbo.Viewings", "PropertyId", c => c.Int(nullable: false));
            DropColumn("dbo.Viewings", "Property_Id");
            AddPrimaryKey("dbo.Viewings", "ViewingId");
            CreateIndex("dbo.Viewings", "PropertyId");
            AddForeignKey("dbo.Viewings", "PropertyId", "dbo.Properties", "Id", cascadeDelete: true);
        }
    }
}

namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Viewings",
                c => new
                    {
                        ViewingId = c.Int(nullable: false, identity: true),
                        PropertyId = c.Int(nullable: false),
                        ViewingStatus = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DateRequested = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ViewingId)
                .ForeignKey("dbo.Properties", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.PropertyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Viewings", "PropertyId", "dbo.Properties");
            DropIndex("dbo.Viewings", new[] { "PropertyId" });
            DropTable("dbo.Viewings");
        }
    }
}

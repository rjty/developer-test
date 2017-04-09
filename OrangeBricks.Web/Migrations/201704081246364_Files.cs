namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Files : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        FileType = c.Int(nullable: false),
                        Property_Id = c.Int(),
                    })
                .PrimaryKey(t => t.FileId)
                .ForeignKey("dbo.Properties", t => t.Property_Id)
                .Index(t => t.Property_Id);
            
            AddColumn("dbo.Properties", "AskingPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Properties", "City", c => c.String(nullable: false));
            AddColumn("dbo.Properties", "District", c => c.String());
            AddColumn("dbo.Properties", "Country", c => c.String());
            AddColumn("dbo.Properties", "ImageThumb", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "Property_Id", "dbo.Properties");
            DropIndex("dbo.Files", new[] { "Property_Id" });
            DropColumn("dbo.Properties", "ImageThumb");
            DropColumn("dbo.Properties", "Country");
            DropColumn("dbo.Properties", "District");
            DropColumn("dbo.Properties", "City");
            DropColumn("dbo.Properties", "AskingPrice");
            DropTable("dbo.Files");
        }
    }
}

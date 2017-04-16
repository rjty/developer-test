namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Properties", "BuyerUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Properties", "BuyerUserId", c => c.Int(nullable: false));
        }
    }
}

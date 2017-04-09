namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Files2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Properties", "AskingPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Properties", "AskingPrice", c => c.String(nullable: false));
        }
    }
}

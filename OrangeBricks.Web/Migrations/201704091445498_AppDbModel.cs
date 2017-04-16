namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppDbModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "PersonId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Files", "PersonId");
        }
    }
}

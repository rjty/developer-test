namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Files1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "County", c => c.String());
            AddColumn("dbo.Properties", "Postalcode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Properties", "Postalcode");
            DropColumn("dbo.Properties", "County");
        }
    }
}

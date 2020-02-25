namespace DRS_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageURLPath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ImageURLPath", c => c.String());
            DropColumn("dbo.Categories", "ImageURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "ImageURL", c => c.String());
            DropColumn("dbo.Categories", "ImageURLPath");
        }
    }
}

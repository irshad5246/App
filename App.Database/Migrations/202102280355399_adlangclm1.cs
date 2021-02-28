namespace App.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adlangclm1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Languages", "ShortCode", c => c.String());
            DropColumn("dbo.Languages", "ShorCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Languages", "ShorCode", c => c.String());
            DropColumn("dbo.Languages", "ShortCode");
        }
    }
}

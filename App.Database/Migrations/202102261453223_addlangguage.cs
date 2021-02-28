namespace App.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlangguage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShorCode = c.String(),
                        IsRTL = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(),
                        ModifiedBy = c.String(),
                        ModifiedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Categories", "CreatedOn", c => c.DateTime());
            AddColumn("dbo.Categories", "ModifiedBy", c => c.String());
            AddColumn("dbo.Categories", "ModifiedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "ModifiedOn");
            DropColumn("dbo.Categories", "ModifiedBy");
            DropColumn("dbo.Categories", "CreatedOn");
            DropTable("dbo.Languages");
        }
    }
}

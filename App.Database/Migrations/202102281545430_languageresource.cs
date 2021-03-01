namespace App.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class languageresource : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LanguageResources",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        LanguageID = c.Int(nullable: false),
                        Value = c.String(),
                        CreatedOn = c.DateTime(),
                        ModifiedBy = c.String(),
                        ModifiedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LanguageResources");
        }
    }
}

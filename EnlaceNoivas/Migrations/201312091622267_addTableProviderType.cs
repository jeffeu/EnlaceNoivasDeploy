namespace EnlaceNoivas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableProviderType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProviderTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Providers", "ProviderType_Id", c => c.Int());
            CreateIndex("dbo.Providers", "ProviderType_Id");
            AddForeignKey("dbo.Providers", "ProviderType_Id", "dbo.ProviderTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Providers", "ProviderType_Id", "dbo.ProviderTypes");
            DropIndex("dbo.Providers", new[] { "ProviderType_Id" });
            DropColumn("dbo.Providers", "ProviderType_Id");
            DropTable("dbo.ProviderTypes");
        }
    }
}

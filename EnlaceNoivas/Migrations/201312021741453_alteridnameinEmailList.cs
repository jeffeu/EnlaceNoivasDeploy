namespace EnlaceNoivas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteridnameinEmailList : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmailLists", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.EmailLists", new[] { "ID" });
            AddPrimaryKey("dbo.EmailLists", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EmailLists", new[] { "Id" });
            AddPrimaryKey("dbo.EmailLists", "ID");
            AlterColumn("dbo.EmailLists", "ID", c => c.Int(nullable: false, identity: true));
        }
    }
}

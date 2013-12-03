namespace EnlaceNoivas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removetimestamp : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmailLists", "TimeStamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmailLists", "TimeStamp", c => c.DateTime(nullable: false));
        }
    }
}

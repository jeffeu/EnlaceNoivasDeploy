namespace EnlaceNoivas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountVoteToCouple : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Couples", "VouteCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Couples", "VouteCount");
        }
    }
}

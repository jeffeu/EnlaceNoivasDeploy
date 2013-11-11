namespace EnlaceNoivas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPostBlogTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PostBlogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Description = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PostBlogs");
        }
    }
}

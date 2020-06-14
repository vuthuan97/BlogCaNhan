namespace BlogCaNhan.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableblog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blog", "noiDungBlog", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blog", "noiDungBlog");
        }
    }
}

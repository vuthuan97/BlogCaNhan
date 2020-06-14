namespace BlogCaNhan.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class swapusersuserweb : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "UserWeb");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserWeb", newName: "Users");
        }
    }
}

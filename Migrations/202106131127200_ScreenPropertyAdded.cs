namespace computer_store_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScreenPropertyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Computers", "Screen", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Computers", "Screen");
        }
    }
}

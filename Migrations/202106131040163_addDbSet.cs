namespace computer_store_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Manufacturer = c.String(nullable: false, maxLength: 255),
                        Model = c.String(nullable: false, maxLength: 255),
                        CPU = c.String(nullable: false, maxLength: 255),
                        RAM = c.Int(nullable: false),
                        Storage = c.Int(nullable: false),
                        PriceILS = c.Int(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Computers");
        }
    }
}

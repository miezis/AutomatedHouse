namespace AutomatedHouse.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Pin = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        House_Id = c.Int(),
                        Room_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Houses", t => t.House_Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id)
                .Index(t => t.House_Id)
                .Index(t => t.Room_Id);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ApiKey = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        House_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Houses", t => t.House_Id)
                .Index(t => t.House_Id);
            
            CreateTable(
                "dbo.Sensors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Pin = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Room_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id)
                .Index(t => t.Room_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Pin = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Room_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id)
                .Index(t => t.Room_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Sensors", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Accessories", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Accessories", "House_Id", "dbo.Houses");
            DropForeignKey("dbo.Rooms", "House_Id", "dbo.Houses");
            DropIndex("dbo.Services", new[] { "Room_Id" });
            DropIndex("dbo.Sensors", new[] { "Room_Id" });
            DropIndex("dbo.Rooms", new[] { "House_Id" });
            DropIndex("dbo.Accessories", new[] { "Room_Id" });
            DropIndex("dbo.Accessories", new[] { "House_Id" });
            DropTable("dbo.Services");
            DropTable("dbo.Sensors");
            DropTable("dbo.Rooms");
            DropTable("dbo.Houses");
            DropTable("dbo.Accessories");
        }
    }
}

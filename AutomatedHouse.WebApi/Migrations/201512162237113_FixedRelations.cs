namespace AutomatedHouse.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedRelations : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Accessories", name: "House_Id", newName: "HouseId");
            RenameColumn(table: "dbo.Accessories", name: "Room_Id", newName: "RoomId");
            RenameColumn(table: "dbo.Sensors", name: "Room_Id", newName: "RoomId");
            RenameColumn(table: "dbo.Services", name: "Room_Id", newName: "RoomId");
            RenameIndex(table: "dbo.Accessories", name: "IX_Room_Id", newName: "IX_RoomId");
            RenameIndex(table: "dbo.Accessories", name: "IX_House_Id", newName: "IX_HouseId");
            RenameIndex(table: "dbo.Sensors", name: "IX_Room_Id", newName: "IX_RoomId");
            RenameIndex(table: "dbo.Services", name: "IX_Room_Id", newName: "IX_RoomId");
            AddColumn("dbo.Sensors", "HouseId", c => c.Int());
            AddColumn("dbo.Services", "HouseId", c => c.Int());
            CreateIndex("dbo.Sensors", "HouseId");
            CreateIndex("dbo.Services", "HouseId");
            AddForeignKey("dbo.Sensors", "HouseId", "dbo.Houses", "Id");
            AddForeignKey("dbo.Services", "HouseId", "dbo.Houses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "HouseId", "dbo.Houses");
            DropForeignKey("dbo.Sensors", "HouseId", "dbo.Houses");
            DropIndex("dbo.Services", new[] { "HouseId" });
            DropIndex("dbo.Sensors", new[] { "HouseId" });
            DropColumn("dbo.Services", "HouseId");
            DropColumn("dbo.Sensors", "HouseId");
            RenameIndex(table: "dbo.Services", name: "IX_RoomId", newName: "IX_Room_Id");
            RenameIndex(table: "dbo.Sensors", name: "IX_RoomId", newName: "IX_Room_Id");
            RenameIndex(table: "dbo.Accessories", name: "IX_HouseId", newName: "IX_House_Id");
            RenameIndex(table: "dbo.Accessories", name: "IX_RoomId", newName: "IX_Room_Id");
            RenameColumn(table: "dbo.Services", name: "RoomId", newName: "Room_Id");
            RenameColumn(table: "dbo.Sensors", name: "RoomId", newName: "Room_Id");
            RenameColumn(table: "dbo.Accessories", name: "RoomId", newName: "Room_Id");
            RenameColumn(table: "dbo.Accessories", name: "HouseId", newName: "House_Id");
        }
    }
}

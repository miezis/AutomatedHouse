namespace AutomatedHouse.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingForeignKeyDefinition : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Rooms", name: "House_Id", newName: "HouseId");
            RenameIndex(table: "dbo.Rooms", name: "IX_House_Id", newName: "IX_HouseId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Rooms", name: "IX_HouseId", newName: "IX_House_Id");
            RenameColumn(table: "dbo.Rooms", name: "HouseId", newName: "House_Id");
        }
    }
}

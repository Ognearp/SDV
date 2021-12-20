namespace SDV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qq : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products_to_delivery", "Id_delivery", "dbo.Delivery");
            DropPrimaryKey("dbo.Delivery");
            AlterColumn("dbo.Delivery", "Id_delivery", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Delivery", "Id_delivery");
            AddForeignKey("dbo.Products_to_delivery", "Id_delivery", "dbo.Delivery", "Id_delivery");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products_to_delivery", "Id_delivery", "dbo.Delivery");
            DropPrimaryKey("dbo.Delivery");
            AlterColumn("dbo.Delivery", "Id_delivery", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Delivery", "Id_delivery");
            AddForeignKey("dbo.Products_to_delivery", "Id_delivery", "dbo.Delivery", "Id_delivery");
        }
    }
}

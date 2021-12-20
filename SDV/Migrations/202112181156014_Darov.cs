namespace SDV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Darov : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Delivery", "Number_delivry", c => c.Int(nullable: false));
            DropColumn("dbo.Delivery", "Id_warehouse");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Delivery", "Id_warehouse", c => c.Int(nullable: false));
            DropColumn("dbo.Delivery", "Number_delivry");
        }
    }
}

namespace SDV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class privet : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Delivery", "id_suplier", "dbo.Suplier");
            DropIndex("dbo.Delivery", new[] { "id_suplier" });
            DropColumn("dbo.Delivery", "id_suplier");
            DropTable("dbo.Suplier");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Suplier",
                c => new
                    {
                        Id_suplier = c.Int(nullable: false, identity: true),
                        name_suplier = c.String(maxLength: 50, unicode: false),
                        adress = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id_suplier);
            
            AddColumn("dbo.Delivery", "id_suplier", c => c.Int(nullable: false));
            CreateIndex("dbo.Delivery", "id_suplier");
            AddForeignKey("dbo.Delivery", "id_suplier", "dbo.Suplier", "Id_suplier");
        }
    }
}

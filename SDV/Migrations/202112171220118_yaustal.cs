namespace SDV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yaustal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Delivery",
                c => new
                    {
                        Id_delivery = c.Int(nullable: false),
                        date_delivery = c.DateTime(nullable: false, storeType: "date"),
                        id_suplier = c.Int(nullable: false),
                        Id_warehouse = c.Int(nullable: false),
                        EmployeesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_delivery)
                .ForeignKey("dbo.Shop_employe", t => t.EmployeesId)
                .ForeignKey("dbo.Suplier", t => t.id_suplier)
                .Index(t => t.id_suplier)
                .Index(t => t.EmployeesId);
            
            CreateTable(
                "dbo.BaseEmployes",
                c => new
                    {
                        EmployeesId = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false, maxLength: 50),
                        password = c.String(nullable: false, maxLength: 50),
                        id_role = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeesId)
                .ForeignKey("dbo.Role_employess", t => t.id_role)
                .Index(t => t.id_role);
            
            CreateTable(
                "dbo.Role_employess",
                c => new
                    {
                        id_role = c.Int(nullable: false, identity: true),
                        decritption_role = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id_role);
            
            CreateTable(
                "dbo.warehouse",
                c => new
                    {
                        Id_warehouse = c.Int(nullable: false, identity: true),
                        name_warehouse = c.String(maxLength: 50, unicode: false),
                        id_employee_warehouse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_warehouse);
            
            CreateTable(
                "dbo.Product_in_warehouse",
                c => new
                    {
                        Id_product = c.Int(nullable: false),
                        Id_warehouse = c.Int(nullable: false),
                        amount_on_warehouse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id_product, t.Id_warehouse })
                .ForeignKey("dbo.Products", t => t.Id_product)
                .ForeignKey("dbo.warehouse", t => t.Id_warehouse)
                .Index(t => t.Id_product)
                .Index(t => t.Id_warehouse);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id_product = c.Int(nullable: false, identity: true),
                        name_product = c.String(nullable: false, maxLength: 50, unicode: false),
                        type_product = c.String(nullable: false, maxLength: 50, unicode: false),
                        cost = c.Double(nullable: false),
                        description = c.String(nullable: false, maxLength: 250, unicode: false),
                        unit_of = c.String(nullable: false, maxLength: 50, unicode: false),
                        photo = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.Id_product);
            
            CreateTable(
                "dbo.Prodoct_in_shop",
                c => new
                    {
                        Id_shop = c.Int(nullable: false),
                        Id_product = c.Int(nullable: false),
                        Kol_vo_v_shop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id_shop, t.Id_product })
                .ForeignKey("dbo.Shop", t => t.Id_shop)
                .ForeignKey("dbo.Products", t => t.Id_product)
                .Index(t => t.Id_shop)
                .Index(t => t.Id_product);
            
            CreateTable(
                "dbo.Shop",
                c => new
                    {
                        Id_shop = c.Int(nullable: false, identity: true),
                        adress = c.String(nullable: false, maxLength: 50, unicode: false),
                        fio_employee = c.String(nullable: false, maxLength: 50, unicode: false),
                        number_phone = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id_shop);
            
            CreateTable(
                "dbo.Products_to_delivery",
                c => new
                    {
                        Id_delivery = c.Int(nullable: false),
                        Id_product = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id_delivery, t.Id_product })
                .ForeignKey("dbo.Products", t => t.Id_product)
                .ForeignKey("dbo.Delivery", t => t.Id_delivery)
                .Index(t => t.Id_delivery)
                .Index(t => t.Id_product);
            
            CreateTable(
                "dbo.Suplier",
                c => new
                    {
                        Id_suplier = c.Int(nullable: false, identity: true),
                        name_suplier = c.String(maxLength: 50, unicode: false),
                        adress = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id_suplier);
            
            CreateTable(
                "dbo.Shop_employe",
                c => new
                    {
                        EmployeesId = c.Int(nullable: false),
                        photo = c.Binary(storeType: "image"),
                        id_shop = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeesId)
                .ForeignKey("dbo.BaseEmployes", t => t.EmployeesId)
                .ForeignKey("dbo.Shop", t => t.id_shop)
                .Index(t => t.EmployeesId)
                .Index(t => t.id_shop);
            
            CreateTable(
                "dbo.Warehouse_employess",
                c => new
                    {
                        EmployeesId = c.Int(nullable: false),
                        warehouse_Id_warehouse = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeesId)
                .ForeignKey("dbo.BaseEmployes", t => t.EmployeesId)
                .ForeignKey("dbo.warehouse", t => t.warehouse_Id_warehouse)
                .Index(t => t.EmployeesId)
                .Index(t => t.warehouse_Id_warehouse);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Warehouse_employess", "warehouse_Id_warehouse", "dbo.warehouse");
            DropForeignKey("dbo.Warehouse_employess", "EmployeesId", "dbo.BaseEmployes");
            DropForeignKey("dbo.Shop_employe", "id_shop", "dbo.Shop");
            DropForeignKey("dbo.Shop_employe", "EmployeesId", "dbo.BaseEmployes");
            DropForeignKey("dbo.Delivery", "id_suplier", "dbo.Suplier");
            DropForeignKey("dbo.Products_to_delivery", "Id_delivery", "dbo.Delivery");
            DropForeignKey("dbo.Product_in_warehouse", "Id_warehouse", "dbo.warehouse");
            DropForeignKey("dbo.Products_to_delivery", "Id_product", "dbo.Products");
            DropForeignKey("dbo.Product_in_warehouse", "Id_product", "dbo.Products");
            DropForeignKey("dbo.Prodoct_in_shop", "Id_product", "dbo.Products");
            DropForeignKey("dbo.Prodoct_in_shop", "Id_shop", "dbo.Shop");
            DropForeignKey("dbo.BaseEmployes", "id_role", "dbo.Role_employess");
            DropForeignKey("dbo.Delivery", "EmployeesId", "dbo.Shop_employe");
            DropIndex("dbo.Warehouse_employess", new[] { "warehouse_Id_warehouse" });
            DropIndex("dbo.Warehouse_employess", new[] { "EmployeesId" });
            DropIndex("dbo.Shop_employe", new[] { "id_shop" });
            DropIndex("dbo.Shop_employe", new[] { "EmployeesId" });
            DropIndex("dbo.Products_to_delivery", new[] { "Id_product" });
            DropIndex("dbo.Products_to_delivery", new[] { "Id_delivery" });
            DropIndex("dbo.Prodoct_in_shop", new[] { "Id_product" });
            DropIndex("dbo.Prodoct_in_shop", new[] { "Id_shop" });
            DropIndex("dbo.Product_in_warehouse", new[] { "Id_warehouse" });
            DropIndex("dbo.Product_in_warehouse", new[] { "Id_product" });
            DropIndex("dbo.BaseEmployes", new[] { "id_role" });
            DropIndex("dbo.Delivery", new[] { "EmployeesId" });
            DropIndex("dbo.Delivery", new[] { "id_suplier" });
            DropTable("dbo.Warehouse_employess");
            DropTable("dbo.Shop_employe");
            DropTable("dbo.Suplier");
            DropTable("dbo.Products_to_delivery");
            DropTable("dbo.Shop");
            DropTable("dbo.Prodoct_in_shop");
            DropTable("dbo.Products");
            DropTable("dbo.Product_in_warehouse");
            DropTable("dbo.warehouse");
            DropTable("dbo.Role_employess");
            DropTable("dbo.BaseEmployes");
            DropTable("dbo.Delivery");
        }
    }
}

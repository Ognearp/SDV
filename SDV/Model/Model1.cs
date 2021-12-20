using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SDV.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model17")
        {
        }

        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Prodoct_in_shop> Prodoct_in_shop { get; set; }
        public virtual DbSet<Product_in_warehouse> Product_in_warehouse { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Products_to_delivery> Products_to_delivery { get; set; }
        public virtual DbSet<Role_employess> Role_employess { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<warehouse> warehouse { get; set; }

        public virtual DbSet<BaseEmployes> BaseEmployes {get;set;}

        public virtual DbSet<employees> Employees { get; set; }
        public virtual DbSet<Warehouse_employess> Warehouse_Employesses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Delivery>()
                .HasMany(e => e.Products_to_delivery)
                .WithRequired(e => e.Delivery)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.name_product)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.type_product)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.unit_of)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Prodoct_in_shop)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Product_in_warehouse)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Products_to_delivery)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role_employess>()
                .Property(e => e.decritption_role)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.adress)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.fio_employee)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.number_phone)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .HasMany(e => e.Prodoct_in_shop)
                .WithRequired(e => e.Shop)
                .WillCascadeOnDelete(false);

          

          

            modelBuilder.Entity<employees>()
               .HasMany(e => e.Delivery)
               .WithRequired(p=>p.Employees)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.name_warehouse)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.Product_in_warehouse)
                .WithRequired(e => e.warehouse)
                .WillCascadeOnDelete(false);

           
            
        }
    }
}

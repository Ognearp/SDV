namespace SDV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using SDV.Services;

    public partial class Products : Base
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Prodoct_in_shop = new HashSet<Prodoct_in_shop>();
            Product_in_warehouse = new HashSet<Product_in_warehouse>();
            Products_to_delivery = new HashSet<Products_to_delivery>();
        }

        [Key]
        public int Id_product { get; set; }

        [Required]
        [StringLength(50)]
        public string name_product { get; set; }

        [Required]
        [StringLength(50)]
        public string type_product { get; set; }

        public double cost { get; set; }

        [Required]
        [StringLength(250)]
        public string description { get; set; }

        [Required]
        [StringLength(50)]
        public string unit_of { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prodoct_in_shop> Prodoct_in_shop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_in_warehouse> Product_in_warehouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products_to_delivery> Products_to_delivery { get; set; }

        public int CurrentShop => Prodoct_in_shop.FirstOrDefault(p => p.Id_shop == (User_services.Instance.CurentEmployees as employees).id_shop).Kol_vo_v_shop;

        public int CurrentWarehouse => Product_in_warehouse.FirstOrDefault(p => p.Id_warehouse == (User_services.Instance.CurentEmployees as Warehouse_employess).warehouse.Id_warehouse).amount_on_warehouse;
    }
}

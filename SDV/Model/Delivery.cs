namespace SDV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Delivery")]
    public partial class Delivery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delivery()
        {
            Products_to_delivery = new HashSet<Products_to_delivery>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_delivery { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_delivery { get; set; }

        public int id_suplier { get; set; }

        public int Id_warehouse { get; set; }

        public int Id_employee { get; set; }

        public virtual employees employees { get; set; }

        public virtual Suplier Suplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products_to_delivery> Products_to_delivery { get; set; }
    }
}

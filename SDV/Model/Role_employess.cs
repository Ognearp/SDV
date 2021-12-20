namespace SDV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role_employess
    {
        [Key]
        public int id_role { get; set; }

        [Required]
        [StringLength(50)]
        public string decritption_role { get; set; }

        public virtual ICollection<BaseEmployes> BaseEmployes { get; set; }
    }
}

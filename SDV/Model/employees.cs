using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV.Model
{

    [Table("Shop_employe")]
    public partial class employees : BaseEmployes
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employees()
        {
            Delivery = new HashSet<Delivery>();
        }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        public int? id_shop { get; set; }

       
        public virtual ICollection<Delivery> Delivery { get; set; }

       
        public virtual Shop Shop { get; set; }


    }
}


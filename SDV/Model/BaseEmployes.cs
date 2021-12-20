using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV.Model
{
    public partial class BaseEmployes
    {
        [Key]
        public int EmployeesId { get; set; }

        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public int? id_role { get; set; }


        public virtual Role_employess Role_employess { get; set; }
    }
}

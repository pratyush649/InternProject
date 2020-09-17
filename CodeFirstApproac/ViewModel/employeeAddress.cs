using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproac.ViewModel
{
    public class employeeAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int addressId { get; set; }

        // Foreign key   
        [Display(Name = "Employee")]
        public  int employeeId { get; set; }

        [ForeignKey("employeeId")]
        public  Employee Employee { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public int wardNo { get; set; }
    }
}

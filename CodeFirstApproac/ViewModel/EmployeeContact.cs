using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproac.ViewModel
{
    public class EmployeeContact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int contactId { get; set; }
        public string mobileNumber { get; set; }
        public string residentNo { get; set; }

        // Foreign key   
        [Display(Name = "Employee")]
        public  int employeeId { get; set; }

        [ForeignKey("employeeId")]
        public  Employee Employee { get; set; }

    }
}

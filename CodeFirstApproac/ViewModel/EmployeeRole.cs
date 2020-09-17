using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproac.ViewModel
{
    public class EmployeeRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeRoleId { get; set; }

        // Foreign key   
        [Display(Name = "Employee")]
        public  int employeeId { get; set; }

        [ForeignKey("employeeId")]
        public  Employee Employee { get; set; }

        // Foreign key   
        [Display(Name = "RoleType")]
        public  int roleTypeId { get; set; }

        [ForeignKey("roleTypeId")]
        public  RoleType RoleType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproac.ViewModel
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeId { get; set; }
        public string fristName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        public string dateOfJoin { get; set; }

        [Display(Name = "gender")]
        public  int genderId { get; set; }

        [ForeignKey("genderId")]
        public  gender gender { get; set; }

        [Display(Name = "Marital")]
        public  int maritalId { get; set; }

        [ForeignKey("maritalId")]
        public  Marital Marital { get; set; }

        [Display(Name = "RoleType")]
        public  int roleTypeId { get; set; }

        [ForeignKey("roleTypeId")]
        public  RoleType RoleType { get; set; }


    }
}

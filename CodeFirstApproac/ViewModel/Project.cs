using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproac.ViewModel
{
    public class Project
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int projectId { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        // Foreign key   
        [Display(Name = "Department")]
        public  int departmentId { get; set; }

        [ForeignKey("departmentId")]
        public  Department Department { get; set; }
    }
}


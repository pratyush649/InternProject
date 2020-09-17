using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproac.ViewModel
{
    public class EmployeeTaskList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeTaskListId { get; set; }

        // Foreign key   
        [Display(Name = "Employee")]
        public  int employeeId { get; set; }

        [ForeignKey("employeeId")]
        public  Employee Employee { get; set; }

        // Foreign key   
        [Display(Name = "TaskList")]
        public  int taskListId { get; set; }

        [ForeignKey("taskListId")]
        public  TaskList TaskList { get; set; }

        // Foreign key   
        [Display(Name = "Project")]
        public  int projectId { get; set; }

        [ForeignKey("projectId")]
        public  Project Project { get; set; }


    }
}

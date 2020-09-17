using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproac.ViewModel
{
    public class TaskList
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int taskListId { get; set; }
        public string taskName { get; set; }
        public string taskStatus { get; set; }
        public string priority { get; set; }

    }
}

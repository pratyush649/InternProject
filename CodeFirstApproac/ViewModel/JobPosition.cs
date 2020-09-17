using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproac.ViewModel
{
    public class JobPosition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int jobPositionId { get; set; }
        public string position { get; set; }
        public string grade { get; set; }
        public int levelNo { get; set; }        
    }
}

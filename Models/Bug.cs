using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker
{
    public class Bug
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string Assignee { get; set; }
        [Display(Name = "Priority Level")]
        public string PriorityLevel { get; set; }
        public string Reporter { get; set; }
        public string Summary { get; set; }
    }
}

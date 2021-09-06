﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker
{
    public class Bug
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime creationDate { get; set; }
        public DateTime dueDate { get; set; }
        public string Status { get; set; }
        public string Assignee { get; set; }
        public string PriorityLevel { get; set; }
        public string Reporter { get; set; }
    }
}
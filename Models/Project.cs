﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string People { get; set; }
        [Display(Name = "Bug ID's")]
        public int BugIDs { get; set; }
        public string Summary { get; set; }
    }
}

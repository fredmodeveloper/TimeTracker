using System;
using System.Collections.Generic;

namespace TimeTracker.Models
{
    public partial class Project
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public int ProjectPlatformID { get; set; }
    }
}

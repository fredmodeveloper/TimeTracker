using System;
using System.Collections.Generic;

namespace TimeTracker.Models
{
    public partial class UserProject
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProjectID { get; set; }
    }
}

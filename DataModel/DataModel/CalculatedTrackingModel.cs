using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
   public class CalculatedTrackingModel
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string Platform { get; set; }
        public double Hours { get; set; }
    }
}

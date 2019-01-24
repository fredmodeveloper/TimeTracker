using System;
using System.Collections.Generic;

namespace TimeTracker.Models
{
    public partial class TimeTracking
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public double HourCount { get; set; }
        public Nullable<double> MinutesCount { get; set; }
        public Nullable<int> TrackingInvoiceID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int UserID { get; set; }
    }
}

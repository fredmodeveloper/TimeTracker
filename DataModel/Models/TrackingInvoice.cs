using System;
using System.Collections.Generic;

namespace TimeTracker.Models
{
    public partial class TrackingInvoice
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public System.DateTime PeriodStartDate { get; set; }
        public System.DateTime PeriodEndDate { get; set; }
        public bool IsPaid { get; set; }
        public int UserID { get; set; }
    }
}

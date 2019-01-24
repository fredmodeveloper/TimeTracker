
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.DataModel;

namespace TimeTracker.Models
{
   public class TimeTrackingModel
    {
        public int ID { get; set; }
        public string Project{ get; set; }
        public string Platform { get; set; }
        public System.DateTime Date { get; set; }
        [NotMapped]
        public string PersianDate
        {
            get
            {
                if (this.Date != DateTime.MinValue)
                    return Tools.ToPersian(Date);
                return "";
            }
        }
        public string Description { get; set; }
        public double HourCount { get; set; }
        public Nullable<double> MinutesCount { get; set; }
        public int? TrackingInvoiceID { get; set; }
        public string TrackingInvoiceDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.DataModel
{
  public  class InvoiceModel
    {
        public int ID { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public string PeriodStartDate {
            get
            {
                if (PeriodStartDateTime != DateTime.MinValue)
                    return Tools.ToPersian(PeriodStartDateTime);
                return "";
            }
        }
        [NotMapped]
        public string PeriodEndDate {

            get
            {
                if (PeriodEndDateTime != DateTime.MinValue)
                    return Tools.ToPersian(PeriodEndDateTime);
                return "";
            }
        }
        public DateTime PeriodStartDateTime { get; set; }
        public DateTime PeriodEndDateTime { get; set; }
        public string IsPaid { get; set; }
        public string User { get; set; }
    }
}

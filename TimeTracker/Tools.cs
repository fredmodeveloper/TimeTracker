using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
   public static class Tools
    {
        private static Models.User _CurrentUser;
        public static Models.User CurrentUser
        {
            get
            {
                return _CurrentUser;
            }
            set
            {
                _CurrentUser = value;
            }
        }
        private static Models.TimeTrackerDBContext _Context;
        public static  Models.TimeTrackerDBContext Context
        {
            get
            {
                if (_Context == null)
                    _Context = new Models.TimeTrackerDBContext();
                return _Context;
            }
            set
            {
                _Context = value;
            }
        }

        public static string ToPersian(this DateTime date)
        {
            var g = new System.Globalization.PersianCalendar();
            return string.Format("{0}/{1}/{2}", g.GetYear(date), g.GetMonth(date).ToString("00"), g.GetDayOfMonth(date).ToString("00"));
        }
        public static DateTime ConvertPersionDate(this string date)
        {
            if (date != null)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(date, @"\d{4}/\d{2}/\d{2}"))
                {
                    var splitted = date.Split('/');
                    var g = new System.Globalization.PersianCalendar();

                    return g.ToDateTime(int.Parse(splitted[0]), int.Parse(splitted[1]), int.Parse(splitted[2]), 0, 0, 0, 0);
                }

                else if (System.Text.RegularExpressions.Regex.IsMatch(date, @"\d{2}/\d{2}/\d{4}"))
                {
                    var splitted = date.Split('/');
                    var g = new System.Globalization.PersianCalendar();

                    return g.ToDateTime(int.Parse(splitted[2].Substring(0, 4)), int.Parse(splitted[0]), int.Parse(splitted[1]), 0, 0, 0, 0);
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(date, @"\d{4}/\d{1}/\d{2}"))
                {
                    var splitted = date.Split('/');
                    var g = new System.Globalization.PersianCalendar();

                    return g.ToDateTime(int.Parse(splitted[0]), int.Parse(splitted[1]), int.Parse(splitted[2]), 0, 0, 0, 0);
                }

                else if (System.Text.RegularExpressions.Regex.IsMatch(date, @"\d{4}/\d{2}/\d{1}"))
                {
                    var splitted = date.Split('/');
                    var g = new System.Globalization.PersianCalendar();

                    return g.ToDateTime(int.Parse(splitted[0]), int.Parse(splitted[1]), int.Parse(splitted[2]), 0, 0, 0, 0);
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(date, @"\d{4}/\d{1}/\d{1}"))
                {
                    var splitted = date.Split('/');
                    var g = new System.Globalization.PersianCalendar();

                    return g.ToDateTime(int.Parse(splitted[0]), int.Parse(splitted[1]), int.Parse(splitted[2]), 0, 0, 0, 0);
                }

            }

            return DateTime.MinValue;
        }
    }
}

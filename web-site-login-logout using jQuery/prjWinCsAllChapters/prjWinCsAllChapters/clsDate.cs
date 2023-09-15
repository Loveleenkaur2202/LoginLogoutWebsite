using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsAllChapters
{
    public class clsDate
    {
        // private fields
        private Int32 vDay;
        private Int32 vMonth;
        private Int32 vYear;

        // public properties for each field
        public Int32 Day
        {
            get { return vDay; }
            set
            {
                vDay = (value > 0 && value < 32) ? value : DateTime.Today.Day;
            }
        }

        public Int32 Month
        {
            get { return vMonth; }
            set
            {
                vMonth = (value > 0 && value < 13) ? value : DateTime.Today.Month;
            }
        }

        public Int32 Year
        {
            get { return vYear; }
            set
            {
                vYear = (value > 0) ? value : DateTime.Today.Year;
            }
        }

        public void SetDate(Int32 day, Int32 month, Int32 year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string ToNumber()
        {
            return Day + "/" + Month + "/" + Year;
        }

        public string ToLetter()
        {
            string[] tabDays =
            {  "Sunday","Monday","Tuesday","Wednesday", "Thursday", "Friday",
                "Saturday"
            };
            string[] tabMonths =
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December",
            };

            DateTime theDate = new DateTime(Year, Month, Day);
            Int32 indxDayWek = Convert.ToInt32(theDate.DayOfWeek);
            string result = tabDays[indxDayWek] + " " + tabMonths[Month - 1];
            result += " " + Day + ", " + Year;
            return result;

        }

    }
}
 
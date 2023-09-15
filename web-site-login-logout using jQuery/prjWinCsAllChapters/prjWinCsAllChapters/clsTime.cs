using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsAllChapters
{
    public class clsTime
    {
        //private fileds that will store the values of the properties
        private int vHour;
        private int vMinute;
        private int vSecond;
           
    public int Hour
        {
            //access to property for reading
            get{ return vHour;}
            //access to the properry for writing 
            set{
                vHour = (value >= 0 && value <= 23 ) ? value : 0;
            
            }
        }

        public int Minute
        {
            //access to property for reading
            get { return vMinute; }
            //access to the properry for writing 
            set
            {
                vMinute = (value >= 0 && value <= 59) ? value : 0;

            }
        }

        public int Second
        {
            //access to property for reading
            get { return vSecond; }
            //access to the properry for writing 
            set
            {
                vSecond = (value >= 0 && value <= 59) ? value : 0;

            }
        }


        public void SetTime(int hour, Int16 minute, Int16 second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public string toStringUniversal()
        {
            return Hour + ":" + Minute + ":" + Second;

        }

       public string toStringStandard()
        {
            string tmp;
            tmp =( (Hour > 12) ? Hour - 12 : Hour) + ":" + Minute +":" +Second;
            tmp = tmp + ((Hour >= 12) ? " PM" : " AM");
            return tmp;

        }
    }
}

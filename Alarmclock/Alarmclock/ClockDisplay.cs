using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmclock
{
    class ClockDisplay
    {
        NumberDisplay _hourDisplay = new NumberDisplay(23);
        NumberDisplay _minuteDisplay = new NumberDisplay(59);

        public int Hour 
       {
           get
           {
               return _hourDisplay.Number;
           }
           set
           {
               if (value < 0 || value > 23)
               {
                   throw new ArgumentException();
               }
           _hourDisplay.Number = value;
           }
       }
        public int Minute
        {
            get
            {
                return _minuteDisplay.Number;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _minuteDisplay.Number = value;
            }
        }
        //Referera till NumberDisplay-objekt
        public ClockDisplay()
            :this (0, 0)
        {}
        public ClockDisplay(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }
        public void Increment()
        {
            _minuteDisplay.Increment();

            if (Minute == 0)
            {
                if (Hour == 23)
                {
                    Hour = 0;
                }
                else
                {
                    Hour++;
                }
            }
        }
        public override string ToString()
        {
            string stringhour = _hourDisplay.ToString();
            string stringminute = _minuteDisplay.ToString();

            return string.Format("{0}:{1:00}", stringhour, stringminute);
        }
    }
}

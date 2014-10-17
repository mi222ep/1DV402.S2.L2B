using Alarmclock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class AlarmClox
    {
       private ClockDisplay _alarmTime = new ClockDisplay();
       private ClockDisplay _time = new ClockDisplay();

       public int AlarmHour
       {
           get
           {
               return _alarmTime.Hour;
           }
           set
           {
               if (value < 0 || value > 23)
               {
                   throw new ArgumentException("Alarmtimmen är inte inom det slutna intervallet 0 och 23");
               }
           _alarmTime.Hour = value;
           
           }
       }
       public int AlarmMinute
       {
           get
           {
               return _alarmTime.Minute;
           }
           set
           {
               if (value < 0 || value >59)
               {
                   throw new ArgumentException("Alarmminuten är inte inom det slutna intervallet 0 och 59");
               }
               _alarmTime.Minute = value;
           }
       }
       public int Hour
       {
           get
           {
               return _time.Hour;
           }
           set
           {
               if(value <0 || value >23)
               {
                   throw new ArgumentException("Timmen är inte inom det slutna intervallet 0 och 23");
               }
               _time.Hour = value;
           }
       }
       public int Minute
       {
           get
           {
               return _time.Minute;
           }
           set
           {
               if(value <0 || value >59)
               {
                   throw new ArgumentException("Minuten är inte inom det slutna intervallet 0 och 59");
               }
               _time.Minute = value;
           }
          
       }
        public AlarmClox()
            :this(0, 00)
        {}
        public AlarmClox(int hour, int minute)
            :this(hour, minute, 0, 00)
        { }
        public AlarmClox(int hour, int minute, int alarmHour, int alarmMinute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentException("Konstruktorn säger nej till din konstiga timme"); 
            }
            Hour = hour;
            if (minute < 0 || minute > 59)
            {
                throw new ArgumentException("Konstruktorn säger nej till din konstiga minut");
            }
            Minute = minute;
            if (alarmHour < 0 || alarmHour > 23)
            {
                throw new ArgumentException("Konstruktorn säger nej till din konstiga alarmtimme");
            }
            AlarmHour = alarmHour;
            if (hour < 0 || hour > 59)
            {
                throw new ArgumentException("Konstruktorn säger nej till din konstiga alarmminut");
            }
            AlarmMinute = alarmMinute;
        }
        public bool TickTock()
        {

            _time.Increment();
            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string stringtime = _time.ToString();
            string stringalarm = _alarmTime.ToString();

            return string.Format("{0}({1})", stringtime, stringalarm);
        }

    }
}

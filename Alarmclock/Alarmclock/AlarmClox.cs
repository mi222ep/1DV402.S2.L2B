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
       ClockDisplay _alarmTime = new ClockDisplay();
       ClockDisplay _time = new ClockDisplay();

       int AlarmHour
       {
           get
           {
               return _alarmTime.Hour;
           }
           set
           {
               if (value < 0 || value > 23)
               {
                   throw new ArgumentException();
               }
           _alarmTime.Hour = value;
           }
       }
       int AlarmMinute
       {
           get
           {
               return _alarmTime.Minute;
           }
           set
           {
               if (value < 0 || value >59)
               {
                   throw new ArgumentException();
               }
               _alarmTime.Minute = value;
           }
       }
       int Hour
       {
           get
           {
               return _time.Hour;
           }
           set
           {
               if(value <0 || value >23)
               {
                   throw new ArgumentException();
               }
               _time.Hour = value;
           }
       }
       int Minute
       {
           get
           {
               return _time.Minute;
           }
           set
           {
               if(value <0 || value >59)
               {
                   throw new ArgumentException();
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
        //Detta är enda konstruktorn som får innehålla kod som leder till att fält i klassen tilldelas värden
        public AlarmClox(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }
        //Metod, då klockan att gå en minut, om ny tid stämmer överens med alarm, returnera TRUE, annars FALSE
        public bool TickTock()
        {
            if (Minute == 59)
            {
                Minute = 0;
                if (Hour == 23)
                {
                    Hour = 0;
                }
                else { Hour++; }

            }
            else { Minute++; }
            if (Hour == AlarmHour && Minute == AlarmMinute)
            {
                return true;
            }
            return false;
        }
        //Metod, retunerar tid + alarmtid, tex 8:42 (16:23)
        public override string ToString()
        {
            return string.Format("{0}:{1}({2}:{3})", Hour, Minute, AlarmHour, AlarmMinute);
        }

    }
}

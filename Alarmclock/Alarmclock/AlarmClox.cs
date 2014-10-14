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
        //AlarmClock innehåller 2 referenser till ClockDisplay,
        //En ansvarar för timmar (0-23), en för minuter(0-59)
        //Om värdet är ental ska noll sättas framför i minuter, men ej i timmar
        //Referens till Clockdisplayobjekt som ansvarar för väckarklockans aktuella tid
        //Kapslas in av AlarmHour och AlarmMinute
       ClockDisplay _alarmTime = new ClockDisplay(2, 23);
       ClockDisplay _time = new ClockDisplay(4, 53);

       int AlarmHour
       {
           get; set;
       }
        int AlarmMinute { get; set; }
        int Hour { get; set; }
        int Minute { get; set; }

        //Konstruktor, måste vara tom, Anropar konstruktorn med 2 parametrar
        public AlarmClox()
            :this(0, 00)
        {
            
        }
        //Konstruktor, måste vara tom, Anropar konstruktorn med 4 parametrar
        public AlarmClox(int hour, int minute)
            :this(0, 00, 0, 00)
        {

        }
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

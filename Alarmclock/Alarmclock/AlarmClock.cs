using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class AlarmClock
    {
        //AlarmClock innehåller 2 referenser till ClockDisplay,
        //En ansvarar för timmar (0-23), en för minuter(0-59)
        //Om värdet är ental ska noll sättas framför i minuter, men ej i timmar
        int AlarmHour { get; set; }
        int AlarmMinute { get; set; }
        int Hour { get; set; }
        int Minute { get; set; }

        //Konstruktor, måste vara tom, Anropar konstruktorn med 2 parametrar
        public AlarmClock()
        {

        }
        //Konstruktor, måste vara tom, Anropar konstruktorn med 4 parametrar
        public AlarmClock(int hour, int minute)
        {

        }
        //Detta är enda konstruktorn som får innehålla kod som leder till att fält i klassen tilldelas värden
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {

        }
        //Metod, dåe klockan att gå en minut, om ny tid stämmer överens med alarm, returnera TRUE, annars FALSE
        public bool TickTock()
        {
            return false;
        }
        //Metod, retunerar tid + alarmtid, tex 8:42 (16:23)
        public string ToString()
        {
            return ("Hej Hej");
        }

    }
}

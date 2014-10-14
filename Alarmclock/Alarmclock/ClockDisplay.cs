using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmclock
{
    class ClockDisplay
    {
        //fältet _hourDisplay och _minuteDisplay kapslar in egenskapen Hour/Minute
        int Hour { get; set; }
        int Minute { get; set; }
        //Konstruktor, Tom kropp, anropar konstruktor med 2 referenser
        public ClockDisplay()
        {

        }
        //onstrutor, Objekt initieras så att tid ställs
        public ClockDisplay(int hour, int minute)
        {

        }
        //Gör att ClockDisplay-objektet går 1 minut, om mintantalet blir 0, skall timme ökas med 1. 
        public void Increment()
        {

        }
        //Retunerar sträng med tiden i formatet HH:mm
        public string ToString()
        {
            return ("hej hej");
        }
    }
}

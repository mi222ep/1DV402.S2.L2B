using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmclock
{
    class ClockDisplay
    {
        //I klassen ClockDisplay ska två privata fält med referenser till
        //NumberDisplay användas 
        //fältet _hourDisplay och _minuteDisplay kapslar in egenskapen Hour/Minute
        public int Hour { get; set; }
        public int Minute { get; set; }
        public ClockDisplay()
            :this (0, 00)
        {}
        public ClockDisplay(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }
        //Gör att ClockDisplay-objektet går 1 minut, om mintantalet blir 0, skall timme ökas med 1. 
        public void Increment()
        {

        }
        //Retunerar sträng med tiden i formatet HH:mm
        public override string ToString()
        {
            return ("hej hej");
        }
    }
}

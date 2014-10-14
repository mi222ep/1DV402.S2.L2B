using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmclock
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klasserna AlarmClock, ClockDisplay och NumberDisplay
            //AlarmClock innehåller 2 referenser till ClockDisplay,
            //En ansvarar för timmar (0-23), en för minuter(0-59)
            //Om värdet är ental ska noll sättas framför i minuter, men ej i timmar
            //I klassen ClockDisplay ska två privata fält med referenser till
            //NumberDisplay användas 
            //En set i NumberDisplay kastar undantag om försök gör att ställa felaktig kod
            //Valideringen av rätt tid sker i NumberDisplay  

            //Test:
            //1. Standardkonstruktion, skriv ut värdet 0:00
            //2. Två parametrar, skriv ut 9:42
            //3. 4 parametrar, skriv ut 13.24 (7:35)
            //4. Låt klockan gå 13 minuter från 23.59
            //5. Ställ alarm 6.15 och låt klockan gå från 6.13
            //6. Kasta undantag vid felaktiga värden EGENSKAPER
            //7. Kasta undanag vid felaktiva värden KONSTRUKTORER
        }
    }
}

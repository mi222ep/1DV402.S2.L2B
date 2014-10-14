using AlarmClock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmclock
{
    class Program
    {
        //testa konstruktorerna, egenskaperna och metoderna
        static void Main(string[] args)
        {
            AlarmClox ac = new AlarmClox(12, 13, 14, 15);
            string test = ac.ToString();
            Console.WriteLine(test);

            //Test:
            //1. Standardkonstruktion, skriv ut värdet 0:00
            //2. Två parametrar, skriv ut 9:42
            //3. 4 parametrar, skriv ut 13.24 (7:35)
            //4. Låt klockan gå 13 minuter från 23.59
            //5. Ställ alarm 6.15 och låt klockan gå från 6.13
            //6. Kasta undantag vid felaktiga värden EGENSKAPER
            //7. Kasta undanag vid felaktiva värden KONSTRUKTORER
        }
        //Första parametern är ett AlarmClockobjekt, andra är antal gånger TickTock skall anropas
        private void Run( AlarmClox ac, int minutes)
        {

        }
        //Felmeddelande som argument
        private void ViewErrorMessage(string message)
        {

        }
        //Sträng som argument och presenterar strängen
        private void ViewTestHeader(string header)
        {

        }
    }
}

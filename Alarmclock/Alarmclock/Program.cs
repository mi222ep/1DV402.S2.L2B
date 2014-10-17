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
        static void Main(string[] args)
        {
            ViewTestHeader("Test nummer 2");
            AlarmClox clock2 = new AlarmClox(12, 01);
            Run(clock2, 1);
            
            ViewTestHeader("Test nummer 3");
            AlarmClox clock3 = new AlarmClox(00, 24, 07, 15);
            Run(clock3, 1);
            
            ViewTestHeader("Test nummer 4");
            AlarmClox clock4 = new AlarmClox(23, 53, 07, 42);
            Run(clock4, 13);

            ViewTestHeader("Test nummer 5");
            AlarmClox clock5 = new AlarmClox(6, 13, 6, 15);
            Run(clock5, 13);

            ViewTestHeader("Test nummer 6");
            try
            {
                clock5.Hour = 77;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                clock5.Minute = 77;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                clock5.AlarmHour = 77;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                clock5.AlarmMinute = 77;
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }

            ViewTestHeader("Test nummer 7");
            try
            {
                AlarmClox finalClox = new AlarmClox(42, 1, 1, 1);
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                AlarmClox finalClox = new AlarmClox(1, 1, 42, 1);
            }
            catch (ArgumentException ex)
            {
                ViewErrorMessage(ex.Message);
            }
            //7. Kasta undanag vid felaktiva värden KONSTRUKTORER
        }
        public static void Run(AlarmClox ac, int minutes)
        {

            for (int i = 0; i < minutes; i++)
            {

                if (ac.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(ac);
                    Console.WriteLine("Beep bepp");
                    Console.ResetColor();

                }
                else
                {
                    Console.WriteLine(ac);
                }
            }
        }
        public static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ViewTestHeader(string header)
        {
            Console.WriteLine("----------------");
            Console.WriteLine(header);
        }
    }
}

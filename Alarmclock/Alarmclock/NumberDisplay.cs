﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmclock
{
    class NumberDisplay
    {
        int _maxNumber;
        int _number;

        int MaxNumber { get; set; }
        int Number { get; set; }
        //Öka NumberDisplayobjektet med 1
        public void increment
        {

        }
        //Konstruktor, tom kropp, anropar nästa konstruktur
        public NumberDisplay(int maxNumber)
        {

        }
        //Konstruktor, Objektets fält tilldelas värdets parametrar
        public NumberDisplay(int maxNumber, int number)
        {

        }
        //Returnerar numret, utan att nummer mindre än 10 inleds med 0
        public string ToString()
        {
            return ("Halloj dä!");
        }
        //Returnerar värdet av en instans av NumberDisplay. Formatsträngen bestämmer om värden mindre än 10 skall inledans med 0. 
        //Är formatsträngen 0 eller G ska numret INTE inledas med 0, är formatsträngen 00 ska numret inledas med 0 om numret är mindre än 10. 
        //Alla övriga värden på formatsträngen ska leda till att FormatException kastas. 
        public string ToString(string format)
        {
            return ("Hallåååå!");
        }
    }
}
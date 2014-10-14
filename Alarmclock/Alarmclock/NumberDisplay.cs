using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarmclock
{
    class NumberDisplay
    {
        private int _maxnumber;
        private int _number;

        public int MaxNumber
        {
            get
            {
                return _maxnumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _maxnumber = value;
            }
        }
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value < 0 || value > MaxNumber)
                {
                    throw new ArgumentException();
                }
                _number = value;
            }
        }
        //Öka NumberDisplayobjektet med 1
        public void Increment()
        {
            Number++;
            if (Number == MaxNumber)
            {
                Number = 0;
            } 
        }
        //Konstruktor, tom kropp, anropar nästa konstruktur
        public NumberDisplay(int maxNumber)
            :this(maxNumber, 00)
        {

        }
        //Konstruktor, Objektets fält tilldelas värdets parametrar
        public NumberDisplay(int maxNumber, int number)
        {
            MaxNumber = maxNumber;
            Number = number;
        }
        //Returnerar numret, utan att nummer mindre än 10 inleds med 0
        public override string ToString()
        {
            return string.Format("{0})", Number);
        }
        //Returnerar värdet av en instans av NumberDisplay. Formatsträngen bestämmer om värden mindre än 10 skall inledans med 0. 
        //Är formatsträngen 0 eller G ska numret INTE inledas med 0, är formatsträngen 00 ska numret inledas med 0 om numret är mindre än 10. 
        //Alla övriga värden på formatsträngen ska leda till att FormatException kastas. 
        public override string ToString(string format)
        {
            return ("Hallåååå!");
        }
    }
}

using SecondTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Classes
{
    class Europian:IDateTime
    {
        private int _hrs, _mins, _month, _day, _year;
        public Europian(int hrs, int mins, int month, int day, int year)
        {
            if (hrs > 0 && mins > 0 && month > 0 && day > 0 && year > 0)
            {
                _hrs = hrs;
                _mins = mins;
                _month = month;
                _day = day;
                _year = year;
            }
            else
            {
                Console.WriteLine("Date is not correct!");
                Environment.Exit(1);
            }
        }

        public void Display()
        {
            CultureInfo cultureInfo = new CultureInfo("fr-FR");
            DateTime dt = new DateTime(_year, _month, _day, _hrs, _mins, 0);


            StringBuilder sb = new StringBuilder();
            sb.Append("Time and date: ");
            sb.Append(dt.ToString(cultureInfo));


            Console.WriteLine(sb.ToString());
        }
    }
}


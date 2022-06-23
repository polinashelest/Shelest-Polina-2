using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab2
{
    class Day : Month
    {
        Day dy = new Day();

        public void ShowDayOfTheWeek()
        {
            DateTime Date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Day of the week: ");
            Console.WriteLine(value: Date.ToString("dddd", new CultureInfo("en-EN")));
        }
        static void DifferenceDates(DateTime Date1, DateTime Date2)
        {

            if (Date1 >= Date2)
            {
                TimeSpan difference = Date1.Subtract(Date2);
            }

            else
            {
                TimeSpan difference = Date2.Subtract(Date1);
            }

            Console.WriteLine("Difference in days: " + difference.Days);
            Console.WriteLine("Difference in months: " + difference.Days / 30);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab2
{
    class Program
    {
        public static object Date { get; set; }

        static void Main()

        {
            Console.Write("Enter date YYYY-MM-DD: ");
            DateTime Date = Convert.ToDateTime(Console.ReadLine());
            DateTime datevalue = (Convert.ToDateTime(Date.ToString()));

            String dy = datevalue.Day.ToString();
            String mn = datevalue.Month.ToString();
            String yy = datevalue.Year.ToString();
        }

        public void ShowDate()
        {
            DateTime Date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Date: ");
            Console.WriteLine(Date.ToString("dd/MM/yyyy"));
        }

        public void SetDatesForComparison()
        {
            Console.Write("Enter date1 YYYY-MM-DD: ");
            DateTime Date1 = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter date2 YYYY-MM-DD: ");
            DateTime Date2 = Convert.ToDateTime(Console.ReadLine());
        }
    }
}

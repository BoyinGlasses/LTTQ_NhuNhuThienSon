using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month, year;
            Console.Write("Nhap thang: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            year = int.Parse(Console.ReadLine());
            int daysInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine("So ngay trong thang {0} nam {1} la: {2}", month, year, daysInMonth);
        }
    }
}

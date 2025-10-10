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
            DateTime dt;
            Console.Write("Nhap thang va nam (MM/yyyy): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                Console.Write("Nhap lai thang va nam (MM/yyyy): ");
            }
            Console.WriteLine("So ngay trong thang {0} nam {1} la {2}", dt.Month, dt.Year, DateTime.DaysInMonth(dt.Year, dt.Month));
        }
    }
}

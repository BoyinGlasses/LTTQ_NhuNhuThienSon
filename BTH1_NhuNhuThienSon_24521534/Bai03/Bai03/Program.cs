using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            Console.Write("Nhap ngay: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            year = int.Parse(Console.ReadLine());
            try { 
                DateTime dateCheck = new DateTime(year, month, day);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ngay thang nam khong hop le!");
                return;
            }
            Console.WriteLine("Ngay thang nam hop le!");

        }
    }
}

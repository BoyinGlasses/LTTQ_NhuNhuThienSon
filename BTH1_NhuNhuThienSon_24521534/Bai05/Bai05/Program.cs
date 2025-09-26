using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            Console.WriteLine("Nhap ngay: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            year = int.Parse(Console.ReadLine());
            string thu = new DateTime(year, month, day).DayOfWeek.ToString();   
            switch (thu) 
            {
                case "Monday":
                    thu = "Hai";
                    break;
                case "Tuesday":
                    thu = "Ba";
                    break;
                case "Wednesday":
                    thu = "Tu";
                    break;
                case "Thursday":
                    thu = "Nam";
                    break;
                case "Friday":
                    thu = "Sau";
                    break;
                case "Saturday":
                    thu = "Bay";
                    break;
                case "Sunday":
                    thu = "Chu Nhat";
                    break;
                default:
                    thu = "Khong hop le";
                    break;
            }
            Console.WriteLine("Ngay {0}/{1}/{2} la thu {3}", day, month, year, thu);

        }
    }
}

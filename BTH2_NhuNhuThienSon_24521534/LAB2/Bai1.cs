using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Bai1
    {
        public static void Run()
        {
            Console.WriteLine("Bai 1:");
            Console.WriteLine("Nhap thang va nam: ");
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int days = DateTime.DaysInMonth(year, month);
            int[,] calendar = new int[6, 7];
            DateTime firstDay = new DateTime(year, month, 1);
            int dayOfWeek = (int)firstDay.DayOfWeek;
            int day = 1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 && j < dayOfWeek)
                    {
                        calendar[i, j] = 0;
                    }
                    else if (day <= days)
                    {
                        calendar[i, j] = day;
                        day++;
                    }
                    else
                    {
                        calendar[i, j] = 0;
                    }
                }
            }   
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (calendar[i, j] == 0)
                    {
                        Console.Write("    ");
                    }
                    else
                    {
                        Console.Write("{0,3} ", calendar[i, j]);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

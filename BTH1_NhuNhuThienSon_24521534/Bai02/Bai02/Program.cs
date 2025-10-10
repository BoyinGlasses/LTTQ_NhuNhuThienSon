using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen duong n: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Vui long nhap mot so nguyen duong: ");
            }
           
            int sum = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine("Tong cac so nguyen to nho hon n la: " + sum);
            Console.WriteLine();
        }
    }
}

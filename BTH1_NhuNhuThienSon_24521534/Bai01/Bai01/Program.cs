using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            double sqrt = Math.Sqrt(n);
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random Random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = Random.Next(int.MinValue, int.MaxValue);
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(arr[i] % 2) == 1)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Tong cac so le trong mang la: " + sum);
            int count = 0;
            for (int i = 0; i < n; i++)
            { 
                if (IsPrime(arr[i]))
                {
                    count++;
                }
            
            }
            Console.WriteLine("So so nguyen to trong mang la: " + count);
            int temp = int.MaxValue;
            foreach (int i in arr)
            {
                int sqrt = (int)Math.Sqrt(i);
                if(sqrt * sqrt == i && i < temp)
                {
                    temp = i;
                }
            }
            if (temp == int.MaxValue)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("So chinh phuong nho nhat trong mang la: " + temp);
            }
        }
    }
}

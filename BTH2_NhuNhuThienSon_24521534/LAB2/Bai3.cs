using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Bai3
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
        public static void Run()
        {
            Console.WriteLine("Bai 3: ");
            Console.Write("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Nhap phan tu [{0},{1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ma tran vua nhap: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nhap so can tim: ");
            int x = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        Console.WriteLine("So {0} xuat hien tai vi tri [{1},{2}]", x, i, j);
                        found = true;
                    }
                }
            }
            if (!found)
                Console.WriteLine("Khong tim thay so {0} trong ma tran", x);
            Console.WriteLine("Cac phan tu la so nguyen to trong ma tran: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (IsPrime(matrix[i,j]))
                    {
                        Console.WriteLine("[{0},{1}] : {2}", i, j, matrix[i,j]);
                    }
                }
            }
            int maxPrimeRow = -1;
            int maxPrimeCount = 0;
            for (int i = 0; i < n; i++)
            {
                int rowPrimeCount = 0;
                for (int j = 0; j < m; j++)
                {
                    if (IsPrime(matrix[i, j]))
                        rowPrimeCount++;
                }
                if (rowPrimeCount > maxPrimeCount)
                {
                    maxPrimeCount = rowPrimeCount;
                    maxPrimeRow = i;
                }
            }
            if (maxPrimeRow != -1)
                Console.WriteLine("Dong co nhieu so nguyen to nhat la: {0} voi {1} so nguyen to.", maxPrimeRow, maxPrimeCount);
            else
                Console.WriteLine("Khong co dong nao chua so nguyen to.");
        }
    }
}

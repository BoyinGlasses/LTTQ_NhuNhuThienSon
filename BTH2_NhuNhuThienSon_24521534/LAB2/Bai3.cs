using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Bai3
    {
        bool isEx
        public static void Run()
        {
            Console.WriteLine("Bai 3: ");
            Console.WriteLine("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
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
        }
    }
}

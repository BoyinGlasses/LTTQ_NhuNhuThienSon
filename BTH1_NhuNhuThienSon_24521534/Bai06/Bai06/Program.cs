using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class Program
    {
        bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int rows;
            int cols;
            Console.WriteLine("Nhap so hang: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(-100, 100);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int max = matrix[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            int min = matrix[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            int d = 0;
            int maxRowSum = int.MinValue;
            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    rowSum += matrix[i, j];
                }
                if (rowSum > maxRowSum)
                {
                    maxRowSum = rowSum;
                    d = i;
                }
            }
            Console.WriteLine("Hang co tong lon nhat la hang " + d + " voi tong la " + maxRowSum);
            int sumNotPrime = 0;
            Program p = new Program();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!p.isPrime(matrix[i, j]))
                    {
                        sumNotPrime += matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Tong cac so khong phai so nguyen to: " + sumNotPrime);
            Console.WriteLine("Nhap dong can xoa: ");
            int k = int.Parse(Console.ReadLine());
            if (k < 0 || k >= rows)
            {
                Console.WriteLine("Chi so dong khong hop le!");
            }
            else
            {
                int[,] newMatrix = new int[rows - 1, cols];
                int newRow = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (i == k) continue;
                    for (int j = 0; j < cols; j++)
                    {
                        newMatrix[newRow, j] = matrix[i, j];
                    }
                    newRow++;
                }
                matrix = newMatrix;
                rows--;
                Console.WriteLine("Ma tran sau khi xoa dong " + k + ":");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
            int maxColIndex = 0;
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] == max)
                    {
                        maxColIndex = j;
                        break;
                    }
                }
            }
            int[,] finalMatrix = new int[rows, cols - 1];
            for (int i = 0; i < rows; i++)
            {
                int newCol = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (j == maxColIndex) continue;
                    finalMatrix[i, newCol] = matrix[i, j];
                    newCol++;
                }
            }
            Console.WriteLine("Ma tran sau khi xoa cot chua gia tri lon nhat:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    Console.Write(finalMatrix[i, j] + "\t");
                }
                Console.WriteLine();


            }
        }
    }
}

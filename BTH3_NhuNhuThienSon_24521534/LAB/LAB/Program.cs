using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Nhan so tuong ung de chon bai tap:");
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("5");
                Console.WriteLine("6");
                Console.WriteLine("7");
                Console.WriteLine("8");
                Console.WriteLine("9");
                Console.WriteLine("0. Thoat chuong trinh");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        {
                            Bai1.Run();
                            break;
                        }
                    case "2":
                         Bai2.Run();
                         break;
                     case "3":
                         Bai3.Run();
                         break;
                     case "4":
                         Bai4.Run();
                         break;
                     case "5":
                         Bai5.Run();
                         break;
                     case "6":
                         Bai6.Run();
                         break;
                     case "7":
                         Bai7.Run();
                         break;
                     case "8":
                         Bai8.Run();
                         break;
                     case "9":
                         Bai9.Run();
                         break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        Console.WriteLine("Vui long nhan so tuong ung de chon bai tap:");
                        choice = Console.ReadLine();
                        break;
                }
            }
        }
    }
}

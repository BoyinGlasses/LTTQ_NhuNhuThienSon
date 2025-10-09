using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chon bai tap: ");
            Console.WriteLine("1. Bai 1");
            Console.WriteLine("2. Bai 2");
            Console.WriteLine("3. Bai 3");
            Console.WriteLine("4. Bai 4");
            Console.WriteLine("5. Bai 5");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Bai1.Run();
                    break;
                case 2:
                    Bai2.Run();
                    break;
                case 3:
                    Bai3.Run();
                    break;
                case 4:
                    Bai4.Run();
                    break;
                case 5:
                    Bai5.Run();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }
        }
    }
}

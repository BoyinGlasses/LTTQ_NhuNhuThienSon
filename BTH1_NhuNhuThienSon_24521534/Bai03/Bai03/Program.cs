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
            DateTime dt;
            Console.WriteLine("Nhap ngay thang nam (dd/mm/yyyy): ");
            while(!DateTime.TryParse(Console.ReadLine(), out dt))
                Console.WriteLine("Ngay thang nam khong hop le! Vui long nhap lai (dd/mm/yyyy): ");
            Console.WriteLine("Ngay thang nam hop le!");

        }
    }
}

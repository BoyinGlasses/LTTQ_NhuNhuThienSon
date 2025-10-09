using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Bai2
    {
        public static void Run()
        {
            Console.WriteLine("Bai 2: ");
            Console.WriteLine("Nhap vao duong dan: ");
            string path = Console.ReadLine();
            if (Directory.Exists(path))
            {
                string[] folder = Directory.GetDirectories(path);
                string[] file = Directory.GetFiles(path);
                if (folder.Length == 0 && file.Length == 0)
                    Console.WriteLine("Thu muc rong.");
                else
                {
                    int fiCount = 0;
                    int foCount = 0;
                    long fiSize = 0;

                    Console.WriteLine("Directory of " + path);
                    foreach (string f in folder)
                    {
                        FileInfo fo = new FileInfo(f);
                        Console.WriteLine("{0,-20} {1,-10} {2,-15} {3,-30}",
                            fo.LastAccessTime.ToString("dd-MM-yyyy HH:mm"),
                            "<DIR>",
                            "",
                            fo.Name);
                        foCount++;
                    }
                    foreach (string f in file)
                    {
                        FileInfo fi = new FileInfo(f);
                        Console.WriteLine("{0,-20} {1,-10} {2,-15} {3,-30}",
                            fi.LastAccessTime.ToString("dd-MM-yyyy HH:mm"),
                            "",
                            fi.Length + " bytes",
                            fi.Name);
                        fiSize+= fi.Length;
                        fiCount++;
                    }

                    Console.WriteLine(" {0} File(s) {1} bytes", fiCount + " ", fiSize);
                    string root = Path.GetPathRoot(path);
                    DriveInfo drive = new DriveInfo(root);
                    Console.WriteLine(" {0} Dir(s) {1} bytes free", foCount + " ", drive.AvailableFreeSpace);
                }
            }
            else
                Console.WriteLine("Duong dan khong hop le.");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Bai4
    {
        public class PhanSo
        {
            private int tuSo;
            private int mauSo;
            public int TuSo
            {
                get { return tuSo; }
                set { tuSo = value; }
            }
            public int MauSo
            {
                get { return mauSo; }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException("Mau khong the bang 0");
                    }
                    mauSo = value;
                }
            }
            public PhanSo(int tu, int mau)
            {
                if (mau == 0)
                {

                    throw new ArgumentException("Mau khong the bang 0");
                }
                tuSo = tu;
                mauSo = mau;
            }
            
            public PhanSo(int tu)
            {
                tuSo = tu;
                mauSo = 1;
            }
            public void nhap()
            {
                int temp;
                Console.Write("Nhap tu so: ");
                string tuInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(tuInput))
                {
                    tuSo = 0;
                }
                else
                {
                    while (!int.TryParse(tuInput, out temp))
                    {
                        Console.Write("Gia tri khong hop le. Vui long nhap lai tu so: ");
                        tuInput = Console.ReadLine();
                    }
                    tuSo = temp;
                }

                Console.Write("Nhap mau so: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    mauSo = 1;
                }
                else
                {
                    while (true)
                    {
                        if (!int.TryParse(input, out temp))
                        {
                            Console.Write("Gia tri khong hop le. Vui long nhap lai mau so: ");
                            input = Console.ReadLine();
                            continue;
                        }
                        if (temp == 0)
                        {
                            Console.Write("Mau khong the bang 0. Vui long nhap lai mau so: ");
                            input = Console.ReadLine();
                            continue;
                        }
                        mauSo = temp;
                        break;
                    }
                }
            }
            public void xuat()
            {
                rutGon();
                Console.Write("{0}/{1}", tuSo, mauSo);
            }
            public void rutGon()
            {
                int a = Math.Abs(tuSo);
                int b = Math.Abs(mauSo);
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                tuSo /= a;
                mauSo /= a;
            }
            //phep toan

            public static PhanSo operator +(PhanSo a, PhanSo b)
                {
                    return new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);
                }
                public static PhanSo operator -(PhanSo a, PhanSo b)
                {
                    return new PhanSo(a.tuSo * b.mauSo - b.tuSo * a.mauSo, a.mauSo * b.mauSo);
                }
                public static PhanSo operator *(PhanSo a, PhanSo b)
                {
                    return new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
                }
                public static PhanSo operator /(PhanSo a, PhanSo b)
                {
                    if (b.tuSo == 0)
                    {
                        throw new DivideByZeroException("Loi chia cho 0");
                    }
                    return new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
                }
        
            //so sanh
            public static bool operator >(PhanSo a, PhanSo b)
            {
                return (a.tuSo * b.mauSo > b.tuSo * a.mauSo);
            }
            public static bool operator <(PhanSo a, PhanSo b)
            {
                return (a.tuSo * b.mauSo < b.tuSo * a.mauSo);
            }
            public static bool operator >=(PhanSo a, PhanSo b)
            {
                return (a.tuSo * b.mauSo >= b.tuSo * a.mauSo);
            }
            public static bool operator <=(PhanSo a, PhanSo b)
            {
                return (a.tuSo * b.mauSo <= b.tuSo * a.mauSo);
            }
            public static bool operator ==(PhanSo a, PhanSo b)
            {
                return (a.tuSo * b.mauSo == b.tuSo * a.mauSo);
            }
            public static bool operator !=(PhanSo a, PhanSo b)
            {
                return (a.tuSo * b.mauSo != b.tuSo * a.mauSo);
            }
            
        }
        public static void Run()
        {
            Console.WriteLine("Bai 4: ");
            Console.WriteLine("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            PhanSo[] a = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = new PhanSo(1, 1);
                Console.WriteLine("Nhap phan so thu {0}: ", i + 1);
                a[i].nhap();
            }
            for (int i = 0; i < n; i++)
            {
                a[i].xuat();
                Console.Write(" ");
            }
            float [] PhanSotrueValue = new float[n];
            for (int i = 0; i < n; i++)
            {
                PhanSotrueValue[i] = (float)a[i].TuSo / a[i].MauSo;
            }
            Array.Sort(PhanSotrueValue, a);
            Console.WriteLine();
            Console.WriteLine("Mang phan so sau khi sap xep: ");
            for (int i = 0; i < n; i++)
            {
                a[i].xuat();
                if (i == n - 1)
                    break;
                Console.Write(" < ");
                
            }

        }
    }

}

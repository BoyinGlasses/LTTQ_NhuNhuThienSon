using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LAB2
{
    internal class Bai5
    {
        class BatDongSan
        {
            public string DiaDiem { get; set; }
            public double GiaBan { get; set; }
            public double DienTich { get; set; }

            public BatDongSan() { }

            public BatDongSan(string diaDiem, double giaBan, double dienTich)
            {
                DiaDiem = diaDiem;
                GiaBan = giaBan;
                DienTich = dienTich;
            }

            public virtual void Nhap()
            {
                Console.Write("Nhap dia diem: ");
                DiaDiem = Console.ReadLine();
                Console.Write("Nhap gia ban (VND): ");
                GiaBan = double.Parse(Console.ReadLine());
                Console.Write("Nhap dien tich (m2): ");
                DienTich = double.Parse(Console.ReadLine());
            }

            public virtual void Xuat()
            {
                Console.WriteLine($"Dia diem: {DiaDiem}, Gia: {GiaBan:N0} VND, Dien tich: {DienTich} m2");
            }
        }

        class NhaPho : BatDongSan
        {
            public int NamXayDung { get; set; }
            public int SoTang { get; set; }

            public NhaPho() { }

            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhap nam xay dung: ");
                NamXayDung = int.Parse(Console.ReadLine());
                Console.Write("Nhap so tang: ");
                SoTang = int.Parse(Console.ReadLine());
            }

            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine($"Nam xay dung: {NamXayDung}, So tang: {SoTang}");
            }
        }
        class ChungCu : BatDongSan
        {
            public int Tang { get; set; }

            public ChungCu() { }

            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nhap tang: ");
                Tang = int.Parse(Console.ReadLine());
            }

            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine($"Tang: {Tang}");
            }
        }

        class KhuDat : BatDongSan
        {
            public KhuDat() { }
            public override void Nhap()
            {
                base.Nhap();
            }
            public override void Xuat()
            {
                base.Xuat();
            }
        }
        static void NhapDanhSach(List<KhuDat> dsd, List<NhaPho> dsn, List<ChungCu> dsc)
        {
            Console.Write("Nhap so khu dat: "); int n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++) { KhuDat k = new KhuDat(); k.Nhap(); dsd.Add(k); }

            Console.Write("Nhap so nha pho: "); int n2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++) { NhaPho n = new NhaPho(); n.Nhap(); dsn.Add(n); }

            Console.Write("Nhap so chung cu: "); int n3 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n3; i++) { ChungCu c = new ChungCu(); c.Nhap(); dsc.Add(c); }
        }
        static void XuatDanhSach(List<KhuDat> dsd, List<NhaPho> dsn, List<ChungCu> dsc)
        {
            Console.WriteLine("\n--- KHU DAT ---");
            foreach (var x in dsd) x.Xuat();

            Console.WriteLine("\n--- NHA PHO ---");
            foreach (var x in dsn) x.Xuat();

            Console.WriteLine("\n--- CHUNG CU ---");
            foreach (var x in dsc) x.Xuat();
        }
        static void TongGiaBan(List<KhuDat> dsd, List<NhaPho> dsn, List<ChungCu> dsc)
        {
            double tongKhuDat = dsd.Sum(x => x.GiaBan);
            double tongNhaPho = dsn.Sum(x => x.GiaBan);
            double tongChungCu = dsc.Sum(x => x.GiaBan);

            Console.WriteLine($"Tong gia ban khu dat: {tongKhuDat:N0} VND");
            Console.WriteLine($"Tong gia ban nha pho: {tongNhaPho:N0} VND");
            Console.WriteLine($"Tong gia ban chung cu: {tongChungCu:N0} VND");
        }
        static void DieuKienXuat(List<KhuDat> dsd, List<NhaPho> dsn)
        {
            Console.WriteLine("\n--- Khu dat > 100m2 ---");
            foreach (var x in dsd.Where(x => x.DienTich > 100))
                x.Xuat();

            Console.WriteLine("\n--- Nha pho > 60m2 va xay nam >= 2019 ---");
            foreach (var x in dsn.Where(x => x.DienTich > 60 && x.NamXayDung >= 2019))
                x.Xuat();
        }
        static void TimKiem(List<NhaPho> dsn, List<ChungCu> dsc)
        {
            Console.Write("Nhap chuoi dia diem can tim ");
            string key = Console.ReadLine().ToLower();
            Console.Write("Nhap gia toi da: ");
            double giaMax = double.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich toi thieu: ");
            double dtMin = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- KET QUA NHA PHO ---");
            foreach (var x in dsn.Where(x =>
                x.DiaDiem.ToLower().Contains(key) && x.GiaBan <= giaMax && x.DienTich >= dtMin))
                x.Xuat();

            Console.WriteLine("\n--- KET QUA CHUNG CU ---");
            foreach (var x in dsc.Where(x =>
                x.DiaDiem.ToLower().Contains(key) && x.GiaBan <= giaMax && x.DienTich >= dtMin))
                x.Xuat();
        }

            public static void Run()
        {
                List<KhuDat> dsKhuDat = new List<KhuDat>();
                List<NhaPho> dsNhaPho = new List<NhaPho>();
                List<ChungCu> dsChungCu = new List<ChungCu>();

                int chon;
                do
                {
                    Console.WriteLine("\n=== QUAN LY CONG TY DIA OC DAI PHU ===");
                    Console.WriteLine("1. Nhap danh sach bat dong san");
                    Console.WriteLine("2. Xuat danh sach bat dong san");
                    Console.WriteLine("3. Xuat tong gia ban tung loai");
                    Console.WriteLine("4. Xuat danh sach khu dat co dien tich > 100m2 hoac la nha pho ma co dien tich > 60m2 va nam xay dung >= 2019 (neu co)");
                    Console.WriteLine("5. Tim kiem");
                    Console.WriteLine("0. Thoat");
                    Console.Write("Chon: ");
                    chon = int.Parse(Console.ReadLine());

                    switch (chon)
                    {
                        case 1:
                            NhapDanhSach(dsKhuDat, dsNhaPho, dsChungCu);
                            break;
                        case 2:
                            XuatDanhSach(dsKhuDat, dsNhaPho, dsChungCu);
                            break;
                        case 3:
                            TongGiaBan(dsKhuDat, dsNhaPho, dsChungCu);
                            break;
                        case 4:
                            DieuKienXuat(dsKhuDat, dsNhaPho);
                            break;
                        case 5:
                            TimKiem(dsNhaPho, dsChungCu);
                            break;
                    }
                } while (chon != 0);
            

        }
    }
}

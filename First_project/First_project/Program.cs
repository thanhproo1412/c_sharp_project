using System;

namespace First_project
{
    class danhSachHocSinh
    {
        public int SoHS;
        public string[] dsHS;
        public int[] dsPoint;
        
    }
    class DanhSachDiem : danhSachHocSinh
    {
        static void tinhDiem(danhSachHocSinh a)
        {
            Console.WriteLine("Nhom : " + nameof(danhSachHocSinh));
            Console.WriteLine("So Hoc Sinh Trong Nhom : " + a.SoHS);
            for (int i = 0; i < a.SoHS; i++)
            {
                Console.WriteLine("Hoc sinh " + a.dsHS[i] + ": " + a.dsPoint[i] + " diem");
            }
        }
        static void Main()
        {
            danhSachHocSinh NhomA = new danhSachHocSinh();
            NhomA.SoHS = 4;
            NhomA.dsHS = new [] { "nguyen", "sy", "hai", "thanh" };
            NhomA.dsPoint = new [] { 9, 7, 10, 8 };
            danhSachHocSinh NhomB = new danhSachHocSinh();
            NhomB.SoHS = 4;
            NhomB.dsHS = new[] { "thanh", "nguyen", "sy", "hai" };
            NhomB.dsPoint = new[] { 10, 7, 8, 9 };
            tinhDiem(NhomA);
            tinhDiem(NhomB);
        }
    }
}
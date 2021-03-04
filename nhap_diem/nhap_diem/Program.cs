using System;

namespace nhap_diem
{
    class XinChao
    {
        static void Main()
        {
            Console.WriteLine("so hoc sinh : ");
            int soHS = Convert.ToInt32(Console.ReadLine());
            string[] dsHS = new string[soHS];
            int[] dsPoint = new int[soHS];
            for (int i = 0; i < soHS; i++)
            {
                Console.WriteLine("Ten Hoc sinh so " + (i + 1));
                dsHS[i] = Console.ReadLine();
                Console.WriteLine("Diem hoc sinh so " + (i + 1));
                dsPoint[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Xin chao cac ban");
            for (int i = 0; i < soHS; i++)
            {
                Console.WriteLine("Hoc sinh " + dsHS[i] + ": " + dsPoint[i] + " diem");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._4
{
    internal class Program
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("=======Menu=======");
                Console.WriteLine("1. Chay Bai tap 1 (Calculator) ");
                Console.WriteLine("2. Chay Bai tap 2 (Phuong trinh bac 2) ");
                Console.WriteLine("3. Chay Bai tap 3 (So nguyen to & Fibonacci) ");
                Console.WriteLine("0. Thoat chuong trinh ");
                Console.WriteLine("==================");
                Console.Write("Nhap lua chon: ");
                choice = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (choice)
                {
                    case 1:
                        BT31.Run();
                        break;

                    case 2:
                        BT32.Run();
                        break;

                    case 3:
                        BT33.Run();
                        break;

                    case 0:
                        Console.WriteLine("Da thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nhan phim bat ky de quay lai Menu...");
                    Console.ReadKey();
                }

            }
            while (choice != 0);
        }
    }
}

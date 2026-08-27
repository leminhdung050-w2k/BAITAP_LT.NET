using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BT32
{
    public static void Run()
    {
        Console.WriteLine("BAI TAP 3.2: PHUONG TRINH BAC 2");
        Console.Write("Nhap so a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap so b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap so c: ");
        double c = double.Parse(Console.ReadLine());

        //TH1: a = 0
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("\nPhuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("\nPhuong trinh vo nghiem");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"\nPhuong trinh co nghiem duy nhat: x = {x}");
            }

        }
        //TH2: a != 0
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("\nPhuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"\nPhuong trinh co nghiem kep: x1 = x2 = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"\nPhuong trinh co hai nghiem phan biet: x1 = {x1}, x2 = {x2}");
            }
        }
    }
}

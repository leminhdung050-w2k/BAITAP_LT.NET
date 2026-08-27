using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BT33
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n <= 1) return false;
        int sum = 1;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0) sum += i;
        }

        return sum == n;
    }

    //Dung phuong phap de quy
    static int fibonacci(int n)
    {
        if (n < 0) return -1;
        else if (n == 0 || n == 1) return n;
        else return fibonacci(n - 1) + fibonacci(n - 2);
    }

    public static void Run()
    {
        Console.WriteLine("===== BAI TAP 3.3: SO NGUYEN TO & FIBONACCI =====");

        int n;
        do
        {
            Console.Write("Nhap so nguyen duong N: ");
            n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Vui long nhap so nguyen duong.");
            }
        }
        while (n <= 0);

        if (IsPrime(n)) Console.WriteLine($"{n} la so nguyen to.");
        else Console.WriteLine($"{n} khong phai la so nguyen to.");

        if (IsPerfectNumber(n)) Console.WriteLine($"{n} la so hoan hao.");
        else Console.WriteLine($"{n} khong phai la so hoan hao.");

        Console.Write($"{n} so Fibonacci dau tien la: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(fibonacci(i) + " ");
        }
        Console.WriteLine();
    }
}

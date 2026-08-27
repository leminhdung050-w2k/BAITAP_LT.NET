using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Nhap so thu nhat a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap phep toan (+, -, *, /, %): ");
            char op = char.Parse(Console.ReadLine());

            double result;

            switch (op)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine("\nKet qua: " + result);
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine("\nKet qua: " + result);
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine("\nKet qua: " + result);
                    break;
                case '/':
                    if (b != 0)
                    {
                        result = a / b;
                        Console.WriteLine("\nKet qua: " + result);
                    }
                    else
                    {
                        Console.WriteLine("\nLoi: Khong the chia cho 0.");
                    }
                    break;
                case '%':
                    if (b != 0)
                    {
                        result = a % b;
                        Console.WriteLine("\nKet qua: " + result);
                    }
                    else
                    {
                        Console.WriteLine("\nLoi: Khong the chia cho 0.");
                    }
                    break;
                default:
                    Console.WriteLine("\nLoi: Phep toan khong hop le.");
                    break;
            }

        }
    }
}

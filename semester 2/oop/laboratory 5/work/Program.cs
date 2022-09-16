using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodArray n1 = new MethodArray(-10, 100, -100);
            Console.WriteLine($"числа равные 50 {n1.N}; сумма чисел {n1.Summ}");
            n1 = new MethodArray(10, 100, -100);
            Console.WriteLine($"числа равные 50 {n1.N}; сумма чисел {n1.Summ}");
            n1 = new MethodArray(10, -100, 100);
            Console.WriteLine($"числа равные 50 {n1.N}; сумма чисел {n1.Summ}");
            n1 = new MethodArray("ef 2323  2312 232, 32, 2323 232   2323");
            Console.WriteLine($"числа равные 50 {n1.N}; сумма чисел {n1.Summ}");
            n1 = new MethodArray("-10 12 34 233 50");
            Console.WriteLine($"числа равные 50 {n1.N}; сумма чисел {n1.Summ}");
        }
    }
}

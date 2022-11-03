using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            MathPendulum m = new MathPendulum(1, 2, 3);
            ITarget a = new Adapter(m);
            Console.WriteLine($"Данные: {a.GetData()}");
            Console.WriteLine($"циклическая частота колебаний = { a.CalculateW()}");
        }
    }
}

using System;

namespace lab_1
{
    class Program
    {
        static Random R = new Random(100);
        static void Main(string[] args)
        {
            WiteTest(3);
            WirePlusTest(3);
        }
        static void WiteTest(int I)
        {
            Console.WriteLine("\n===============================\nТест класса Wire:\n===============================\n");
            for (int i = 0; i < I; i++)
            {
                double b = (double)R.Next(1, 21) / R.Next(1, 5);
                Wire a = new Wire(WireTypeGenerate(), R.Next(1, 21), b);
                Console.WriteLine($"\nПровод №{(i+1)}:");
                Console.WriteLine(a);
            }
        }
        static void WirePlusTest(int I)
        {
            Console.WriteLine("\n===============================\nТест класса WirePlus:\n===============================\n");
            for (int i = 0; i < I; i++)
            {
                bool b = R.Next(0, 2) == 1 ? true : false;
                double c = (double)R.Next(1, 21) / R.Next(1, 5);
                WirePlus a = new WirePlus(WireTypeGenerate(), R.Next(1, 21), c, b);
                Console.WriteLine($"\nПровод №{(i + 1)}:");
                Console.WriteLine(a);
            }
        }
        static string WireTypeGenerate() 
        {
            return (Char.ConvertFromUtf32(R.Next(97, 103)) + Char.ConvertFromUtf32(R.Next(97, 103))) + "-" + R.Next(100, 1000).ToString();
        }
    }
}

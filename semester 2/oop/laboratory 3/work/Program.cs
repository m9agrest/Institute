using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Задание 1=====");
            Work1();
            Console.WriteLine("\n=====Задание 2=====");
            Work2();
            Console.WriteLine("\n=====Задание 3=====");
            Work3();
        }
        static void Work1()
        {
            Console.WriteLine("Введите кол-во элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int summ = 0;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-1000, 1000);
                if (arr[i] > 0 && arr[i] % 10 == 0)
                {
                    summ += arr[i];
                }
            }

            Console.WriteLine("Задание 1: " + summ);
            Console.WriteLine("Задание 2: ");
            for (int i = 0; i < arr.Length; i++) { if (arr[i] % 5 == 0) { Console.WriteLine(arr[i]); } }

            Console.WriteLine("Задание 3: ");
            Console.WriteLine("Введите число:");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пары:");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + t == arr[i + 1])
                {
                    Console.WriteLine(i + " и " + (i + 1));
                }
            }
        }

        static int Work2()
        {
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine("N не по дходит по условию (N<=10)");
                return 1;
            }
            int[,] arr = new int[n, n];
            long a = 1;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int ii = 0; ii < n; ii++)
                {
                    arr[i, ii] = rnd.Next(1, 50);
                    Console.Write(arr[i, ii] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                int min = arr[0, i];
                for (int ii = 1; ii < n; ii++)
                {
                    if (arr[ii, i] < min) { min = arr[ii, i]; }
                }
                a *= min;
            }
            Console.WriteLine("Произведение: " + a);
            return 0;
        }

        static void Work3()
        {
            float[,] arr = new float[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int ii = 0; ii < 5; ii++)
                {
                    arr[i, ii] = (float)rnd.Next(-10, 10) / rnd.Next(1, 10);
                    Console.Write(arr[i, ii] + "  ");
                    if (i == 0 && arr[i, ii] < 0) { arr[i, ii] = 0.69f; }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int ii = 0; ii < 5; ii++)
                {
                    Console.Write(arr[i, ii] + "  ");
                }
                Console.WriteLine();
            }
        }

    }
}
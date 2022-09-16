using System;

namespace Lab4
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Задание 1=====");
            Work1();
            Console.WriteLine("\n=====Задание 2=====");
            Work2();
            Console.WriteLine("\n=====Задание 3=====");
            Work3();
            Console.WriteLine("\n=====Задание 4=====");
            Work4();
            Console.WriteLine("\n=====Задание 5=====");
            Work5();
            Console.WriteLine("\n=====Задание 6=====");
            Work6();
        }

        static void Work1()
        {
            Console.WriteLine("Введите объём первого тела");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу первого тела");
            float m1 = float.Parse(Console.ReadLine());
            float p1 = v1 / m1;
            Console.WriteLine("Плотность первого тела = " + p1 + "\n");
            Console.WriteLine("Введите объём второго тела");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу второго тела");
            float m2 = float.Parse(Console.ReadLine());
            float p2 = v2 / m2;
            Console.WriteLine("Плотность второго тела = " + p1 + "\n");
            if (p1 > p2)
            {
                Console.WriteLine("Плотность первого тела больше второго");
            } else if (p1 == p2)
            {
                Console.WriteLine("Плотности равны");
            } else
            {
                Console.WriteLine("Плотность второго тела больше первого");
            }
        }

        static int Work2()
        {
            Console.WriteLine("Введите двузначное число");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 99 || n < 10)
            {
                Console.WriteLine("Ваше число не двузначное");
                return 1;
            }
            int na = n / 10 + n % 10;
            if (na > 9)
            {
                Console.WriteLine("А) сумма цифр вашего числа - двузначная");
            }
            else
            {
                Console.WriteLine("А) сумма цифр вашего числа - не двузначная");
            }
            Console.WriteLine("Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());
            if (na > a)
            {
                Console.WriteLine("Б) сумма цифр вашего числа - больше числа А");
            }
            else if (na == a)
            {
                Console.WriteLine("Б) сумма цифр вашего числа - равна числу А");
            }
            else
            {
                Console.WriteLine("Б) сумма цифр вашего числа - меньше числа А");
            }
            return 0;
        }

        static int Work3()
        {
            Console.WriteLine("Введите размер стороны А треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер стороны В треугольника");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер стороны С треугольника");
            int c = Convert.ToInt32(Console.ReadLine());
            if (!(a+b>c && b+c>a && a+c>b))
            {
                Console.WriteLine("Треугольника с такими сторонами не может существовать");
                return 1;
            }
            if(a==b || b==c || c == a)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
            }
            return 0;
        }

        static void Work4()
        {
            Console.WriteLine("Ведите число Х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводите числа (0 - окончание ввода)");
            int n = 1;
            int i = 0;
            int summ = 0;
            while (n!=0)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n>x)
                {
                    summ += n;
                }
                if (Math.Abs(n) % 2 == 0)
                {
                    i++;
                }
            }
            Console.WriteLine("А) сумма чисел больше Х = " + summ);
            Console.WriteLine("Б) кол-во четных цифр" + i);
        }

        static void Work5()
        {
            Console.WriteLine("Ведите число Х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x;
            while (a / 10 != 0)
            {
                a /= 10;
            }
            if (a <= 6)
            {
                Console.WriteLine("А) первая цифра Х не превышиает 6");
            }
            else
            {
                Console.WriteLine("А) первая цифра Х превышиает 6");
            }
            Console.WriteLine("Ведите число M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (a <= m)
            {
                Console.WriteLine("А) первая цифра Х не превышиает число M");
            }
            else
            {
                Console.WriteLine("А) первая цифра Х превышиает число M");
            }
        }

        static void Work6()
        {
            Console.WriteLine("Четырех значные числа которые при делении на 133 дают в остатке 125 и при делении на 134 дают в остатке 111:");
            for (int i = 1000; i < 10000; i++)
            {
                if(i%133 == 125 && i%134 == 111)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

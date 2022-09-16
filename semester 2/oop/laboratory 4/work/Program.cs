using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=====Задание 1=====");
            code1();
            Console.WriteLine("\n=====Задание 2=====");
            code2();
            Console.WriteLine("\n=====Задание 3=====");
            code3();
            Console.WriteLine("\n=====Задание 4=====");
            code4();
            Console.WriteLine("\n=====Задание 5=====");
            code5();
        }

        static void code1()
        {
            Console.WriteLine("Введите любую строку, а мы подсчитаем кол-во чисел от 0 до 9 в ней:");
            string text = Console.ReadLine();
            int n = 0;
            for(int i = 0; i < text.Length; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (text[i].ToString().Equals(k.ToString())) n++;
                }
            }
            Console.WriteLine("Кол-во чисел от 0 до 9: " + n);
        }
        static void code2()
        {
            Console.WriteLine("Введите любую строку, а мы в ней после каждого * добавим =:");
            string text = Console.ReadLine();
            text = text.Replace("*", "*=");
            Console.WriteLine("вот что получилось:\n" + text);
        }
        static void code3()
        {
            Console.WriteLine("Введите любую строку, а мы подсчитаем кол-во + и - в ней:");
            string text = Console.ReadLine();
            int np = 0, nm = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString().Equals("+")) np++;
                else if (text[i].ToString().Equals("-")) nm++;
            }
            Console.WriteLine("Кол-во +: " + np + "\nКол-во -:" + nm);
        }
        static void code4()
        {
            Console.WriteLine("Введите любую строку, а мы подсчитаем какое кол-во одинаковых символов в начале:");
            string text = Console.ReadLine();
            int n = 1;
            for (; n < text.Length && text[n].ToString().Equals(text[n-1].ToString());n++ );
            if (n == 1 && text.Length > 1) n=0;
            Console.WriteLine("Кол-во одинаковых символов в начале: " + n);
            if(n == 0) Console.WriteLine("В начале строки нет одинаковых символов");
            else if (n == 1) Console.WriteLine("В строке только 1 символ");
            else if(n == text.Length) Console.WriteLine("Все символы в строке одинаковые");
            else Console.WriteLine("Лишь часть символов в начале строки одинаково");
        }
        static void code5()
        {
            Console.WriteLine("Введите любое предложение, а мы заменим в нем все буквосочетания ах на ух");
            string text = Console.ReadLine();
            text = text.Replace("ах", "ух");
            Console.WriteLine("вот что получилось:\n" + text);
        }
    }
}

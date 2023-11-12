using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    static class Converter
    {
        static Dictionary<char, int> Numbers = new Dictionary<char, int>();
        static Dictionary<int, char> Keys = new Dictionary<int, char>();
        static Dictionary<float, string> RomeNumbers = new Dictionary<float, string>();
        static Converter()
        {
            Numbers.Add('0', 0);
            Numbers.Add('1', 1);
            Numbers.Add('2', 2);
            Numbers.Add('3', 3);
            Numbers.Add('4', 4);
            Numbers.Add('5', 5);
            Numbers.Add('6', 6);
            Numbers.Add('7', 7);
            Numbers.Add('8', 8);
            Numbers.Add('9', 9);
            Numbers.Add('a', 10);
            Numbers.Add('b', 11);
            Numbers.Add('c', 12);
            Numbers.Add('d', 13);
            Numbers.Add('e', 14);
            Numbers.Add('f', 15);
            foreach(KeyValuePair<char, int> pair in Numbers)
            {
                Keys.Add(pair.Value, pair.Key);
            }


            RomeNumbers.Add(1, "I");
            RomeNumbers.Add(1.5f, "V");
            RomeNumbers.Add(2, "X");
            RomeNumbers.Add(2.5f, "L");
            RomeNumbers.Add(3, "C");
            RomeNumbers.Add(3.5f, "D");
            RomeNumbers.Add(4, "M");
        }
        static public string Convert(string number, int original, int final)
        {
            string r = "";
            int num = 0;

            for (int i = 0; i < number.Length; i++)
            {
                num += Numbers[number[^(i + 1)]] * (int)Math.Pow(original, i);
            }

            while (num > 0)
            {
                int a = num % final;
                num /= final;
                r = Keys[a] + r;
            }

            return r;
        }
        static public string toRomeNumbers(string number, int original)
        {
            string r = "";
            number = Convert(number, original, 10);
            for (int I = 1; I <= number.Length; I++)
            {
                string _r = "";
                switch (number[^I])
                {
                    case '1':
                        _r = RomeNumbers[I];
                        break;
                    case '2':
                        _r = RomeNumbers[I] + RomeNumbers[I];
                        break;
                    case '3':
                        _r = RomeNumbers[I] + RomeNumbers[I] + RomeNumbers[I];
                        break;
                    case '4':
                        _r = RomeNumbers[I] + RomeNumbers[I + 0.5f];
                        break;
                    case '5':
                        _r = RomeNumbers[I + 0.5f];
                        break;
                    case '6':
                        _r = RomeNumbers[I + 0.5f] + RomeNumbers[I];
                        break;
                    case '7':
                        _r = RomeNumbers[I + 0.5f] + RomeNumbers[I] + RomeNumbers[I];
                        break;
                    case '8':
                        _r = RomeNumbers[I + 0.5f] + RomeNumbers[I] + RomeNumbers[I] + RomeNumbers[I];
                        break;
                    case '9':
                        _r = RomeNumbers[I] + RomeNumbers[I + 1];
                        break;
                }
                r = _r + r;
            }
            return r;
        }
    }
}

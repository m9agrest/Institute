using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace work
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Dictionary<int, string> IntWords = new Dictionary<int, string>()
        {
            {-1, "Минус"},
            {0, "Ноль"},
            {1, "Один"},
            {2, "Два"},
            {3, "Три"},
            {4, "Четыре"},
            {5, "Пять"},
            {6, "Шесть"},
            {7, "Семь"},
            {8, "Восемь"},
            {9, "Девять"},

            {10, "Десять"},
            {11, "Одиннадцать"},
            {12, "Двенадцать"},
            {13, "Тринадцать"},
            {14, "Четырнадцать"},
            {15, "Пятнадцать"},
            {16, "Шестнадцать"},
            {17, "Семнадцать"},
            {18, "Восемнадцать"},
            {19, "Девятнадцать"},

            {20, "Двадцать"},
            {30, "Тридцать"},
            {40, "Сорок"},
            {50, "Пятьдесят"},
            {60, "Шестьдесят"},
            {70, "Семьдесят"},
            {80, "Восемьдесят"},
            {90, "Девяносто"},

            {100, "Сто"},
            {200, "Двести"},
            {300, "Триста"},
            {400, "Четыреста"},
            {500, "Пятьсот"},
            {600, "Шестьсот"},
            {700, "Семьсот"},
            {800, "Восемьсот"},
            {900, "Девятьсот"},

            {1000, "Одна Тысяча"},
            {2000, "Две Тысячи"},
            {3000, "Три Тысячи"},
            {4000, "Четыре Тысячи"},
            {5000, "Пять Тысяч"},
            {6000, "Шесть Тысяч"},
            {7000, "Семь Тысяч"},
            {8000, "Восемь Тысяч"},
            {9000, "Девять Тысяч"},
            {10000, "Десять Тысяч"}
        };
        long NumberNext = 0;
        Opertions Opertion = Opertions.NONE;
        long NumberResult = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        void AddNumber(object sender, RoutedEventArgs e)
        {
            int number = 0;
            if(sender != null && sender is Button)
            {
                object obj = ((Button)sender).Content;
                if(obj != null && obj is string && int.TryParse((string)obj, out number))
                {
                    NumberNext = NumberNext * 10 + number;
                    tNext.Content = NumberNext;
                }
            }
        }
        void Result(object sender, RoutedEventArgs e)
        {
            switch(Opertion)
            {
                case Opertions.NONE:
                    if(NumberNext != 0)
                    {
                        NumberResult = NumberNext;
                    }
                    break;
                case Opertions.PLUS:
                    NumberResult += NumberNext;
                    break;
                case Opertions.MINUS:
                    NumberResult -= NumberNext;
                    break;
                case Opertions.DIVIDE:
                    if(NumberNext != 0)
                    {
                        NumberResult /= NumberNext;
                    }
                    else
                    {
                        return;
                    }
                    break;
                case Opertions.MULTIPLY:
                    NumberResult *= NumberNext;
                    break;
                case Opertions.POW:
                    NumberResult = (long)Math.Pow(NumberResult, NumberNext);
                    break;
                case Opertions.SQRT:
                    if (NumberNext != 0)
                    {
                        NumberResult = (long)Math.Pow(NumberResult, 1 / (double)NumberNext);
                    }
                    else
                    {
                        return;
                    }
                    break;
            }
            Opertion = Opertions.NONE;
            NumberNext = 0;
            tResult.Content = "";
            tNext.Content = IntToWord(NumberResult);
        }
        void C(object sender, RoutedEventArgs e)
        {
            NumberNext = 0;
            NumberResult = 0;
            Result(null, null);
        }
        void CE(object sender, RoutedEventArgs e)
        {
            NumberNext = 0;
            Result(null, null);
        }


        void Operations(object sender, RoutedEventArgs e)
        {
            if (sender != null && sender is Button && ((Button)sender).Content is string)
            {
                string obj = (string)((Button)sender).Content;
                if(NumberNext != 0 || Opertion == Opertions.NONE )
                {
                    Result(null, null);
                }
                    
                switch (obj)
                {
                    case "+":
                        Opertion = Opertions.PLUS;
                        break;
                    case "-":
                        Opertion = Opertions.MINUS;
                        break;
                    case "*":
                        Opertion = Opertions.MULTIPLY;
                        break;
                    case "/":
                        Opertion = Opertions.DIVIDE;
                        break;
                    case "^":
                        Opertion = Opertions.POW;
                        break;
                    case "√":
                        Opertion = Opertions.SQRT;
                        break;
                    default:
                        Opertion = Opertions.NONE;
                        break;
                }
                if(Opertion != Opertions.NONE)
                {
                    tResult.Content = NumberResult + " " + obj;
                    tNext.Content = NumberNext;
                }
            }
        }

        string IntToWord(long num)
        {
            if(num <= 10000 && num >= -10000)
            {
                return IntToWord((int)num);
            }
            return num.ToString();
        }
        string IntToWord(int num)
        {
            string r = "";
            bool minus = false;
            int n = 0;
            if(num == 0)
            {
                return IntWords[0];
            }
            if (num < 0)
            {
                minus = true;
                num *= -1;
            }
            n = num % 100;
            if (n < 20 && n > 0)
            {
                r += " " + IntWords[n];
                num -= n;
            }

            n = 1;
            while(num != 0)
            {
                n *= 10;
                if(num % n > 0)
                {
                    r = IntWords[num % n] + " " + r;
                    num -= num % n;
                }
            }
            if(minus)
            {
                r = IntWords[-1] + " " + r;
            }



            return r;
        }
    }
    enum Opertions
    {
        PLUS, MINUS, DIVIDE, MULTIPLY, POW, SQRT, NONE
    }
}

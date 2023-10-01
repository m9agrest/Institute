using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace work
{
    /// <summary>
    /// Логика взаимодействия для test.xaml
    /// </summary>
    public partial class test : Window
    {
        public test()
        {
            InitializeComponent();
            xWidth.Content = Width;
            xHeaight.Content = Height;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tOutput.Text = "";
            if (tInput.Text != String.Empty)
            {
                for(int i = 0; i < tInput.Text.Length; i++)
                {
                    byte[] bi = Encoding.Default.GetBytes(tInput.Text[i].ToString()); //Перевод строки в байты
                    string hex = BitConverter.ToString(bi).Replace("-", ""); //Перевод строки в 16ричную систему счисления
                    tOutput.Text += Convert.ToString(Convert.ToInt64(hex, 16), 2); //Вывод результата
                }
            }
        }

        private void resize(object sender, SizeChangedEventArgs e)
        {
            xWidth.Content = e.NewSize.Width;
            xHeaight.Content = e.NewSize.Height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class test : Window
    {
        public test() : this("en-US") { }
        public test(string culture)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }
        private void bEnter_Click(object sender, RoutedEventArgs e)
        {
            if (tLogin.Text.Equals("ROOT") && pPassword.Password.Equals("toor"))
            {
                MessageBox.Show(
                    Properties.Resources.LoginCorrect,
                    Properties.Resources.Window,
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                    );
            }
            else
            {
                MessageBox.Show(
                    Properties.Resources.LoginDiscorrect,
                    Properties.Resources.Window,
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error
                    );
            }


        }
    }
}

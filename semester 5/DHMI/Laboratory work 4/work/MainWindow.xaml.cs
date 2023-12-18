using System;
using System.Windows;

namespace work
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e) => Convert(S10.Text, 10);
        private void Button_Click_1(object sender, RoutedEventArgs e) => Convert(S2.Text, 2);
        private void Button_Click_2(object sender, RoutedEventArgs e) => Convert(S3.Text, 3);
        private void Button_Click_3(object sender, RoutedEventArgs e) => Convert(S8.Text, 8);
        private void Button_Click_4(object sender, RoutedEventArgs e) => Convert(S16.Text, 16);



        void Convert(String num, int original)
        {
            if(!Converter.isCorect(num, original))
            {
                MessageBox.Show($"Ошибка: {num} не относится к {original} системе счисления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            S10.Text = Converter.Convert(num, original, 10);
            S2.Text = Converter.Convert(num, original, 2);
            S3.Text = Converter.Convert(num, original, 3);
            S8.Text = Converter.Convert(num, original, 8);
            S16.Text = Converter.Convert(num, original, 16);
            SR.Content = Converter.toRomeNumbers(num, original);
        }
    }
}

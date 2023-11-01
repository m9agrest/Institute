using System.Windows;
using System.Windows.Input;

namespace work
{
    public partial class test : Window
    {
        public test()
        {
            InitializeComponent();
        }
        private void One(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Вы нажали \'Ctrl+Q\'");
        }
        private void Two(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Вы нажали \'Ctrl+Alt+W\'");
        }
        private void Three(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Вы нажали \'Shift+E\'");
        }

    }
}

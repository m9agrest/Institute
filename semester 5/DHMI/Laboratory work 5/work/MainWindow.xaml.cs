using System.Windows;
using System.Windows.Navigation;

namespace work
{
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow() : this("ru-RU") { }
        public MainWindow(string culture)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }
    }
}

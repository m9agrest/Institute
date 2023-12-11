
using System.Windows;

namespace work
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBase test = new DataBase("localhost", 3306, "course", "root", "");//new DataBase("test1");
            //test.AddCode(7, "rus"); - работает
        }
    }
}

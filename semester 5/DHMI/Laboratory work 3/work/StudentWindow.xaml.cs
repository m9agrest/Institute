using System.Windows;
using System.Windows.Input;

namespace work
{
    public partial class StudentWindow : Window
    {
        Student Student;
        public StudentWindow(Student student)
        {
            Student = student;
            InitializeComponent();
        }
        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}

using System.Windows;

namespace LB3
{
    public partial class WindowStudent : Window
    {
        public Student student = new Student();
        public WindowStudent() => InitializeComponent();

        public WindowStudent(Student student):this()
        {
            InputSurname.Text = student.Surname;
            InputName.Text = student.Name;
            InputPatronymic.Text = student.Patronymic;
            InputFaculty.Text = student.Faculty;
            InputGroup.Text = student.Group;
            InputDateBirth.Text = student.DateBirth;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if(
                InputSurname.Text.Trim()    == "" || 
                InputName.Text.Trim()       == "" || 
                InputPatronymic.Text.Trim() == "" ||
                InputFaculty.Text.Trim()    == "" || 
                InputGroup.Text.Trim()      == "" ||
                InputDateBirth.Text         == null)
            {
                MessageBox.Show("Введите все данные!");
                return;
            }
            student.Name = InputName.Text.Trim();
            student.Surname = InputSurname.Text.Trim();
            student.Patronymic = InputPatronymic.Text.Trim();
            student.Faculty = InputFaculty.Text.Trim();
            student.Group = InputGroup.Text.Trim();
            student.DateBirth = InputDateBirth.Text;
            DialogResult = true;
        }

        private void Cancel(object sender, RoutedEventArgs e) => DialogResult = false;
        private void Clear(object sender, RoutedEventArgs e)
        {
            InputSurname.Clear();
            InputName.Clear();
            InputPatronymic.Clear();
            InputFaculty.Clear();
            InputGroup.Clear();
            InputDateBirth.Text = null;
        }
    }
}

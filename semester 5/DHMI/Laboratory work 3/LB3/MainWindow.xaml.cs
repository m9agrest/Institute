using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace LB3
{
    public partial class MainWindow : Window
    {
        public List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            Students.ItemsSource = students;
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            WindowStudent window = new WindowStudent();
            if(window.ShowDialog() == true)
            {
                students.Add(window.student);
                Students.Items.Refresh();
            }
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            if(Students.SelectedIndex >= 0 && students.Count < Students.SelectedIndex)
            {
                WindowStudent window = new WindowStudent(students[Students.SelectedIndex]);
                if (window.ShowDialog() == true)
                {
                    students[Students.SelectedIndex] = window.student;
                    Students.Items.Refresh();
                }
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (Students.SelectedIndex >= 0 && students.Count < Students.SelectedIndex)
            {
                students.Remove(students[Students.SelectedIndex]);
                Students.Items.Refresh();
            }
        }
    }
}

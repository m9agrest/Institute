using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace work
{
    public partial class PageList : Page
    {
        static List<JObject> Book = new List<JObject>();
        static string LastFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public PageList()
        {
            InitializeComponent();
            WindowTitle = Properties.Resources.ListBook;
            foreach(JObject book in Book)
                List.Items.Add(book["title"].ToString() + " - " + book["author"].ToString());
        }

        public void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "json Files (*.json)|*.json|All Files (*.*)|*.*";
            dialog.InitialDirectory = LastFolder;
            // if (dialog.ShowDialog()) - error
            // if ((bool)dialog.ShowDialog()) - warn
            // dialog.ShowDialog() -> bool?
            if (dialog.ShowDialog() == true) 
            {
                string? lastFolder = Path.GetDirectoryName(dialog.FileName);
                if (lastFolder != null)
                {
                    LastFolder = lastFolder;
                    JObject? book = null;
                    try
                    {
                        book = JObject.Parse(File.ReadAllText(dialog.FileName));
                    }
                    catch { }
                    if(book != null)
                        if (book.ContainsKey("title") && book["title"].Type == JTokenType.String &&
                            book.ContainsKey("author") && book["author"].Type == JTokenType.String &&
                            book.ContainsKey("year") && book["year"].Type == JTokenType.String &&
                            book.ContainsKey("sections") && book["sections"].Type == JTokenType.Array)
                        {
                            Book.Add(book);
                            List.Items.Add(book["title"] + " - " + book["author"]);
                        }
                        else
                            MessageBox.Show(Properties.Resources.noJSON, Properties.Resources.Error, MessageBoxButton.OK, MessageBoxImage.Error);
                    else
                        MessageBox.Show(Properties.Resources.dontOpenFile, Properties.Resources.Error, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void OpenBook(object sender, RoutedEventArgs e)
        {
            if(List.SelectedIndex >= 0 && List.SelectedIndex < Book.Count)
                NavigationService.Navigate(new PageBook(Book[List.SelectedIndex]));
        }

    }
}

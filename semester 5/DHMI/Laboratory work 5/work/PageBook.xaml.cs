using Newtonsoft.Json.Linq;
using System.Windows;
using System.Windows.Controls;

namespace work
{
    public partial class PageBook : Page
    {
        static JObject Book;
        public PageBook(JObject book)
        {
            InitializeComponent();
            WindowTitle = book["title"] + " - " + book["author"];
            Title.Content = book["title"];
            Author.Content = book["author"];
            Year.Content = book["year"];
            Book = book;
            JArray array = (JArray)book["sections"];
            foreach(JObject obj in array)
            {
                string str = "";
                if(obj.ContainsKey("title") && obj["title"].Type == JTokenType.String)
                    str = (string)obj["title"];
                if(obj.ContainsKey("subtitle") && obj["subtitle"].Type == JTokenType.String)
                {
                    if(str != "")
                        str += " - ";
                    str += (string)obj["subtitle"];
                }
                List.Items.Add(str);
            }
        }
        public void OpenSection(object sender, RoutedEventArgs e)
        {
            if (List.SelectedIndex >= 0 && List.SelectedIndex < Book.Count)
                NavigationService.Navigate(new PageText((JObject)((JArray)Book["sections"])[List.SelectedIndex]));
        }
        public void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

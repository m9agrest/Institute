using Newtonsoft.Json.Linq;
using System.Windows;
using System.Windows.Controls;

namespace work
{
    public partial class PageText : Page
    {
        public PageText(JObject book)
        {
            InitializeComponent();
            string str = "";
            if (book.ContainsKey("title") && book["title"].Type == JTokenType.String)
            {
                str = (string)book["title"];
                Title.Content = (string)book["title"];
            }
            if (book.ContainsKey("subtitle") && book["subtitle"].Type == JTokenType.String)
            {
                if (str != "")
                    str += " - ";
                str += (string)book["subtitle"];
                SubTitle.Content = (string)book["subtitle"];
            }
            WindowTitle = str;
            if(book.ContainsKey("text") && book["text"].Type == JTokenType.String)
                Text.Text = (string)book["text"];

        }
        public void Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;

namespace LB6
{
    public partial class MainWindow : Window
    {
        WebClient wClient = new WebClient()
        {
            Encoding = Encoding.UTF8
        };
        const string URL = "https://www.mivlgu.ru/fakultety/fitr/pin/prepodavatelskiy-sostav";
        public MainWindow()
        {
            InitializeComponent();
            UpdateData(null, null);
        }
        private void UpdateData(object sender, RoutedEventArgs ev)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(
                wClient.DownloadString(URL).Replace(
                    "class=\"h_query\"></div>              </div>  <br />", 
                    "class=\"h_query\"></div> <br />"
                    )
                );
            IEnumerable<HtmlNode> elements = doc.GetElementbyId("content").Elements("div").Where(
                e => e.Attributes["class"].Value.Contains("teacher_inf")
                );

            ListBoxTeachers.Items.Clear();
            foreach (HtmlNode el in elements)
            {
                Teacher teacher = new Teacher();
                HtmlNode info = el.Elements("div").Where(
                    e => e.Attributes["class"].Value == "general_inf"
                    ).ToList()[0];
                string imgUrl = info.Elements("div").Where(
                    e => e.Attributes["class"].Value == "teacher_photo"
                    ).ToList()[0].Element("a").Element("img").Attributes["src"].Value; 
                teacher.ImageUrl = new Uri(imgUrl);
                HtmlNode shortInfo = info.Elements("div").Where(
                    e => e.Attributes["class"].Value == "pers_data"
                    ).ToList()[0];
                teacher.Name = shortInfo.Elements("field").Where(
                    e => e.Attributes["class"].Value == "name field-inf"
                    ).ToList()[0].Element("value").InnerText;
                teacher.Rank = shortInfo.Elements("field").Where(
                    e => e.Attributes["class"].Value == "up_rank field-inf"
                    ).ToList()[0].Element("value").InnerText;
                teacher.Title = shortInfo.Elements("field").Where(
                    e => e.Attributes["class"].Value == "title field-inf"
                    ).ToList()[0].Element("value").InnerText;
                teacher.Post = shortInfo.Elements("field").Where(
                    e => e.Attributes["class"].Value == "post field-inf"
                    ).ToList()[0].Element("value").InnerText;
                teacher.Conditions = shortInfo.Elements("field").Where(
                    e => e.Attributes["class"].Value == "cond field-inf"
                    ).ToList()[0].Element("value").InnerText;
                ListBoxTeachers.Items.Add(teacher);
            }
        }
    }
}

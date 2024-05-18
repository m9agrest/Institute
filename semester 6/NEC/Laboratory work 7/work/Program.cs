using HtmlAgilityPack;
using System.Net;
using System;
using System.Text;

namespace work
{
    internal class Program
    {
        static IEnumerable<HtmlNode> elements;
        static string[] args = {"search", "fitr", "pin", "1"};
        static WebClient wClient = new WebClient()
        {
            Encoding = Encoding.UTF8
        };
        static void Main()
        {
            fSearch();
        }
        static void fHelp()
        {

        }
        static void fSearch()
        {
            if (args.Length > 2)//Search fitr pin
            {
                string URL = "https://www.mivlgu.ru/fakultety/" + args[1] + "/" + args[2] + "/prepodavatelskiy-sostav";
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(
                    wClient.DownloadString(URL).Replace(
                        "class=\"h_query\"></div>              </div>  <br />",
                        "class=\"h_query\"></div> <br />"
                    )
                );
                elements = doc.GetElementbyId("content").Elements("div").Where(
                    e => e.Attributes["class"].Value.Contains("teacher_inf")
                );
                if(args.Length > 3)//Search fitr pin 1
                {
                    fInfoTeacher();
                }
                else//Search fitr pin
                {
                    fListTeacher();
                }
            }
            else if (args.Length > 1)//Search fitr
            {
                fListDepartment();
            }
            else //Search
            {
                fListFaculty();
            }
        }
        static void fInfoTeacher()
        {
            int l = 0;
            if (int.TryParse(args[3], out l))
            {
                int i = 0;
                foreach (HtmlNode el in elements)
                {
                    i++;
                    if (i == l)
                    {
                        HtmlNode info = el.Elements("div").Where(
                            e => e.Attributes["class"].Value == "general_inf"
                            ).ToList()[0];
                        HtmlNode shortInfo = info.Elements("div").Where(
                            e => e.Attributes["class"].Value == "pers_data"
                            ).ToList()[0];

                        Console.WriteLine(shortInfo.Elements("field").Where(
                            e => e.Attributes["class"].Value == "name field-inf"
                            ).ToList()[0].Element("value").InnerText);
                        Console.WriteLine(shortInfo.Elements("field").Where(
                            e => e.Attributes["class"].Value == "up_rank field-inf"
                            ).ToList()[0].Element("value").InnerText);
                        Console.WriteLine(shortInfo.Elements("field").Where(
                            e => e.Attributes["class"].Value == "title field-inf"
                            ).ToList()[0].Element("value").InnerText);
                        Console.WriteLine(shortInfo.Elements("field").Where(
                            e => e.Attributes["class"].Value == "post field-inf"
                            ).ToList()[0].Element("value").InnerText);
                        Console.WriteLine(shortInfo.Elements("field").Where(
                            e => e.Attributes["class"].Value == "cond field-inf"
                            ).ToList()[0].Element("value").InnerText);
                        i = -1;
                        break;
                    }
                    if (i > -1)
                    {
                        Console.WriteLine("запись не найдена");
                    }
                }
            }
            else
            {
                Console.WriteLine("неправильный аргумент");
            }
        }
        static void fListTeacher()
        {
            int i = 0;
            foreach (HtmlNode el in elements)
            {
                i++;
                HtmlNode info = el.Elements("div").Where(
                    e => e.Attributes["class"].Value == "general_inf"
                    ).ToList()[0];
                HtmlNode shortInfo = info.Elements("div").Where(
                    e => e.Attributes["class"].Value == "pers_data"
                    ).ToList()[0];

                Console.WriteLine(i + ") " + shortInfo.Elements("field").Where(
                    e => e.Attributes["class"].Value == "name field-inf"
                    ).ToList()[0].Element("value").InnerText);
            }
        }
        static void fListFaculty()
        {

        }
        static void fListDepartment()
        {

        }
    }
}
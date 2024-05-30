using HtmlAgilityPack;
using System.Net;
using System;
using System.Text;

namespace work
{
    internal class Program
    {
        static WebClient wClient = new WebClient()
        {
            Encoding = Encoding.UTF8
        };
        static HtmlDocument doc = new HtmlDocument();
        static HtmlNode node;
        static string[] commands;
        static void Main()
        {
            while (true)
            {
                Console.Write(">");
                string command = Console.ReadLine();
                commands = command.Split(" ");
                if(commands.Length > 0) {
                    switch(commands[0])
                    {
                        case "exit":
                            if (Exit())
                            {
                                return;
                            }
                            break;
                        case "help": Help(); break;
                        case "title": Title(); break;
                        case "url": Url(); break;
                        case "img": Img(); break;
                        default: Console.WriteLine("Error: команда не найдена"); break;
                    }
                }
            }
        }
        static bool Load()//title https://habr.com/ru/articles/145820/
        {
            if(commands.Length > 1)
            {
                doc.LoadHtml(wClient.DownloadString(commands[1]));
                node = doc.DocumentNode;
                return true;
            }
            Console.WriteLine("Error: ссылка не указана");
            return false;
        }
        static void Help()
        {
            Console.WriteLine("help - подсказка по всем командам");
            Console.WriteLine("exit - выход с программы");
            Console.WriteLine("title [url] - выводит заголовки (с h1 по h6) с указаного сайта");
            Console.WriteLine("url [url] - выводит все ссылки и их названия с указаного сайта");
            Console.WriteLine("img [url] - выводит ссылки всех изображений с указаного сайта");
        }
        static bool Exit()
        {
            Console.WriteLine("Выйти? [y/n]");
            while (true)
            {
                char key = Console.ReadKey(false).KeyChar;
                if (key == 'y')
                {
                    return true;
                }
                else if (key == 'n')
                {
                    break;
                }
            }
            return false;
        }
        static void Title()
        {
            if (Load())
            {
                IEnumerable<HtmlNode> elements = node.SelectNodes("//*[self::h1 or self::h2 or self::h3 or self::h4 or self::h5 or self::h6]");
                if(elements != null)
                {
                    foreach (HtmlNode element in elements)
                    {
                        Console.WriteLine(element.Name + ": " + element.InnerText);
                    }
                }
                else
                {
                    Console.WriteLine("Error: Элементов не найдено");
                }
            }
        }
        static void Url()
        {
            if (Load())
            {
                IEnumerable<HtmlNode> elements = node.SelectNodes("//a[@href]");
                foreach (HtmlNode element in elements)
                {
                    string href = element.Attributes["href"].Value;
                    if (!href.StartsWith("http"))
                    {
                        href = commands[1] + href;
                    }
                    Console.WriteLine(element.InnerText + ": " + href);
                }
            }
        }
        static void Img()
        {
            if (Load())
            {
                IEnumerable<HtmlNode> elements = node.SelectNodes("//img[@src]");
                foreach (HtmlNode element in elements)
                {
                    string src = element.Attributes["src"].Value;
                    if (!src.StartsWith("http"))
                    {
                        src = commands[1] + src;
                    }
                    Console.WriteLine(src);
                }
            }
        }
    }
}
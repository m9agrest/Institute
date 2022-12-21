using System.Globalization;
using System.Text.RegularExpressions;

class program
{
    static void Main(string[] arg)
    {
        Context context = new Context();
        string text = "";

        context.Strategy = new StrategyEmail();
        Console.WriteLine("Strategy Email");
        text = "wdwdd.wd";
        Console.WriteLine(text + " - " + context.Check(text));
        text = "   wd@wdd.wd";
        Console.WriteLine(text + " - " + context.Check(text));
        text = "sqsdwfiuweg@gmail.com";
        Console.WriteLine(text + " - " + context.Check(text));
        text = "sqsdwfiu weg@gmail.com";
        Console.WriteLine(text + " - " + context.Check(text));

        context.Strategy = new StrategyAuto();
        Console.WriteLine("Strategy Auto");
        text = "ф1тт1";
        Console.WriteLine(text + " - " + context.Check(text));
        text = "   А120гБ";
        Console.WriteLine(text + " - " + context.Check(text));
        text = "а111аа";
        Console.WriteLine(text + " - " + context.Check(text));
        text = "а12бв";
        Console.WriteLine(text + " - " + context.Check(text));
        text = "а1 42бв";
        Console.WriteLine(text + " - " + context.Check(text));
    }
}

class Context
{
    public IStrategy Strategy { get; set; } = null;
    public Context(IStrategy Strategy) => this.Strategy = Strategy;
    public Context() { }

    public bool Check(string text) => Strategy != null ? Strategy.Check(text) : false;
}


interface IStrategy
{
    public bool Check(string text);
}
class StrategyEmail : IStrategy
{
    public bool Check(string text) => Regex.IsMatch(text.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$");
}
class StrategyAuto : IStrategy
{
    public bool Check(string text) => Regex.IsMatch(text.Trim().ToLower(), @"[а-я]\d{3}[а-я]{2}");
}
/*
class StrategyPhone : IStrategy
{
    public bool Check(string text) => Regex.IsMatch(text.Trim(), @"\\+?\s*\d{1,3}\s*\\(?\s*\d{3}\s*\\)?\s*\\-?\s*\d{3}\s*\\-?\s*\d{2}\s*\\-?\s*\d{2}");
}
*/
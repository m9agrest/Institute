using System.Globalization;
using System.Text.RegularExpressions;

class program
{
    static Context context = new Context();
    static void Main(string[] arg)
    {
        context.Strategy = new StrategyEmail();
        cmd("wdwdd.wd");
        cmd("   wd@wdd.wd");
        cmd("sqsdwfiuweg@gmail.com");
        cmd("sqsdwfiu weg@gmail.com");
        context.Strategy = new StrategyAuto();
        cmd("ф1тт1");
        cmd("   А120гБ");
        cmd("а111аа");
        cmd("а12бв");
        cmd("а1 42бв");
        context.Strategy = new StrategyPhone();
        cmd("8 920 999 99 99");
        cmd("+8 ( 920 999 99 99");
        cmd("      8 920 999 - 99 99");
        cmd("89209999999");
        cmd("+7(800)555 35-35");
        context.Strategy = new StrategyFIO();
        cmd("ЗубенкоМихаилПетрович");
        cmd("Зубенко МихаилПетрович");
        cmd("Зубенко");
        cmd("Зубенко Михаил Петрович");
        cmd("зубенко михаил пЕТРОВИЧ");
        context.Strategy = new StrategyPassport();
        cmd("11 11 111111");
        cmd("111 11 1111");
        cmd("1234567890");
        cmd("1122 334455");
        context.Strategy = new StrategyPIPN();
        cmd("111 111 111 11");
        cmd("111 - 111 - 111 11");
        cmd("11122233344455");
        cmd("111 111 111 111");
        context.Strategy = new StrategyPassword();
        cmd("уыаглцн?*:?:%цвшгцевщгцв");
        cmd("фывйцвц676876348ывцвыв");
        cmd("12345678");
        cmd("1234");
        cmd("12GfcTdffc34");
    }
    static void cmd(string text)
    {
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
    public StrategyEmail()
    {
        Console.WriteLine("\nStrategy Email\n");
    }
    public bool Check(string text) => Regex.IsMatch(text.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$");
}
class StrategyAuto : IStrategy
{
    public StrategyAuto()
    {
        Console.WriteLine("\nStrategy Auto\n");
    }
    public bool Check(string text) => Regex.IsMatch(text.Trim().ToLower(), @"[а-я]\d{3}[а-я]{2}");
}
class StrategyPhone : IStrategy
{
    public StrategyPhone()
    {
        Console.WriteLine("\nStrategy Phone\n");
    }
    public bool Check(string text) => Regex.IsMatch(text.Trim(), @"\+?\s*\d{1,3}\s*\(?\s*\d{3}\s*\)?\s*\-?\s*\d{3}\s*\-?\s*\d{2}\s*\-?\s*\d{2}");
}
class StrategyFIO : IStrategy
{
    public StrategyFIO()
    {
        Console.WriteLine("\nStrategy FIO\n");
    }
    public bool Check(string text) => Regex.IsMatch(text.Trim().ToLower(), @"[а-я]{1,}\s*[а-я]{1,}\s*[а-я]{1,}");
}
class StrategyPassport : IStrategy
{
    public StrategyPassport()
    {
        Console.WriteLine("\nStrategy Passport\n");
    }
    public bool Check(string text) => Regex.IsMatch(text.Trim(), @"\d{2}\s*\d{2}\s*\d{6}");
}
class StrategyPIPN : IStrategy
{
    public StrategyPIPN()
    {
        Console.WriteLine("\nStrategy PIPN\n");
    }
    public bool Check(string text) => Regex.IsMatch(text.Trim(), @"\d{3}\s*\-?\s*\d{3}\s*\-?\s*\d{3}\s*\-?\s*\d{2}");
}
class StrategyPassword : IStrategy
{
    public StrategyPassword()
    {
        Console.WriteLine("\nStrategy Password\n");
    }
    public bool Check(string text)
    {
        if(Regex.IsMatch(text, @"[а-яa-z]{1,}"))
            if (Regex.IsMatch(text, @"[А-ЯA-Z]{1,}"))
                if (Regex.IsMatch(text, @"\d{1,}"))
                    if(text.Length >= 8)
                        return true;
        return false;
    }
}
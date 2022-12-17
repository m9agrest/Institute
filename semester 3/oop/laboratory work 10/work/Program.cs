using System.Globalization;

class program
{
    static void Main(string[] arg)
    {
        string fio = "дЕмо теСТОВич         бИТОВ";
        Context context = new Context();
        Console.WriteLine("Original string:\n" + context.Processing(fio) + "\n");
        Console.WriteLine("Strategy null:\n" + context.Processing(fio) + "\n");
        context.Strategy = new StrategyA();
        Console.WriteLine("StrategyA:\n" + context.Processing(fio) + "\n");
        context.Strategy = new StrategyB();
        Console.WriteLine("StrategyB:\n" + context.Processing(fio));
    }
}

class Context
{
    public IStrategy Strategy { get; set; } = null;
    public Context(IStrategy Strategy) => this.Strategy = Strategy;
    public Context() { }
    public string Processing(string text) => Strategy != null ? Strategy.Convert(text) : text;
}


interface IStrategy
{
    public string Convert(string text);
}
class StrategyA : IStrategy
{
    static TextInfo textInfo = new CultureInfo("ru-RU").TextInfo;
    public string Convert(string text) => textInfo.ToTitleCase(textInfo.ToLower(text.Trim()));
}
class StrategyB : IStrategy
{
    static TextInfo textInfo = new CultureInfo("ru-RU").TextInfo;
    public string Convert(string text)
    {
        string[] arr = text.Split(' ');
        List<string> list = new List<string>();
        for(int i = 0; i < arr.Length; i++)
            if(arr[i] != null && arr[i] != "")
                list.Add(textInfo.ToTitleCase(textInfo.ToLower(arr[i])));
        string r = "";
        for (int i = 0; i < list.Count; i++)
            if (i + 1 < list.Count)
                r += list[i] + " ";
            else
                r += list[i];
        return r;
    }
}
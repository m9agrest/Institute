using System.Text.RegularExpressions;


char[] keysSeparator = { ':', '<', '>', '=', '+', '-', '*', '/', ';' };
string[] keysSeparatorCombo = { "<=", ">=", ":=" };
string code = """
    for i:=10         
    to 100 do        



    y:= i+       
    
    
    
    x;
    """;


Console.WriteLine("изначальный код:\n" + code);
code.Replace('\t', ' ');
code.Replace('\n', ' ');

for (int i = 0; i < keysSeparator.Length; i++)
{
    string reg = @"\" + keysSeparator[i] + "";
    code = Regex.Replace(code, reg, " " + keysSeparator[i] + " ");
}


for(int i = 0; i < keysSeparatorCombo.Length; i++)
{
    string reg = @"";
    string Separator = "";
    for (int j = 0; j < keysSeparatorCombo[i].Length; j++)
    {
        reg += keysSeparatorCombo[i][j];
        Separator += keysSeparatorCombo[i][j];
        if (j < keysSeparatorCombo[i].Length - 1)
        {
            reg += "  ";
        }
    }
    code = Regex.Replace(code, reg, Separator);
}
code.Trim();
code = Regex.Replace(code, @"\s{2,}", " ");

Console.WriteLine("Преобразованный код:\n" + code);

string[] codes = code.Split(' ');
Console.WriteLine("Разделение:\n");
for(int i = 0; i < codes.Length; i++)
{
    if (codes[i].Length >= 1)
    {
        Console.Write(codes[i]);
        bool check = false;
        if (int.TryParse(codes[i], out int a))
        {
            Console.WriteLine(" - литерал");
            check = true;
        }
        if (!check)
        {
            for (int j = 0; j < keysSeparator.Length; j++)
            {
                if (codes[i][0] == keysSeparator[j])
                {
                    Console.WriteLine(" - разделитель");
                    check = true;
                    break;
                }
            }
        }
        if (!check)
        {
            Console.WriteLine(" - идентификатор");
        }
    }
}
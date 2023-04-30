using System.Text.RegularExpressions;

string code = "for i:=10 to : 100 do y:= i+x;";
code.Replace('\t', ' ');
code.Replace('\n', ' ');


string[] keysSeparator = { "<=", ">=", ":=", ":", "<", ">", "=", "+", "-", "*", "/", ";" };
string pattern = @"(";
for(int i = 0; i < keysSeparator.Length; i++)
{
    if (keysSeparator[i].Length == 1)
        pattern += "\\";
    pattern += keysSeparator[i];
    if (keysSeparator.Length > i + 1)
        pattern += "|";
    else
        pattern += ")";
}
string[] myArray = code.Split(' ').SelectMany(
        word => Regex.Split(
            word, pattern
            )
        ).ToArray();
foreach ( string key in myArray)
{
    Console.WriteLine( '"' + key + '"' );
}


string[] keysI =
{
    "for",
    "to",
    "if",
    "do"
};
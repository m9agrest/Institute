class program
{
    static void Main(string[] args)
    {
        string code = "for i := 10 to 100 do y := i + x;";
    }




    public static bool IsDelimiter(Token token)
    {
        return Delimiters.Contains(token.Type);
    }
    public static bool IsSpecialWord(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return false;
        }
        return (SpecialWords.ContainsKey(word));
    }
    public static bool IsSpecialSymbol(char ch)
    {
        return SpecialSymbols.ContainsKey(ch);
    }



    static TokenType[] Delimiters = new TokenType[]
    {
        TokenType.SEMICOLON,
        TokenType.PLUS,
        TokenType.MINUS,
        TokenType.EQUAL,
        TokenType.RPAR,
        TokenType.LPAR
    };
    static Dictionary<string, TokenType> SpecialWords = new Dictionary<string, TokenType>() 
    {
        { "int", TokenType.INT },
        { "bool", TokenType.BOOL },
        { "if", TokenType.IF },
        { "else", TokenType.ELSE },
        { "{", TokenType.BEGIN },
        { "}", TokenType.END }
    };
    static Dictionary<char, TokenType> SpecialSymbols = new Dictionary<char, TokenType>()
    {
        { ';', TokenType.SEMICOLON },
        { '(', TokenType.LPAR },
        { ')', TokenType.RPAR },
        { '+', TokenType.PLUS },
        { '-', TokenType.MINUS },
        { '=', TokenType.EQUAL },
    };
}
class Token
{
    public TokenType Type;
    public string Value;
    public Token(TokenType type)
    {
        Type = type;
    }
    public override string ToString()
    {
        return string.Format("{0}, {1}", Type, Value);
    }
}
public enum TokenType
{
    INT, BOOL, LITERAL, NUMBER, IDENTIFIER, BEGIN, END,
    IF, ELSE, TRUE, FALSE, LPAR, RPAR, PLUS,
    MINUS, EQUAL, SEMICOLON
}
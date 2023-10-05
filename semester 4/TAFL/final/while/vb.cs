using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace work
{
    public class generation
    {
        public static string[] Split(string code)
        {
            code = code.Replace('\t', ' ');
            //code = code.Replace('\n', ' ');

            string pattern = @"(";
            int i = 0;
            foreach (KeyValuePair<string, TokenType> entry in Token.SpecialSymbols) 
            {
                pattern += "\\";
                pattern += entry.Key;
                if (Token.SpecialSymbols.Count > i + 1) pattern += "|";
                else pattern += @")";
                i++;
            }
            string[] myArray = code.Split(' ').SelectMany(
                    word => Regex.Split(
                        word, pattern
                        )
                    ).ToArray();
            return myArray;
        }
        public static Token[] Tokens(string[] keys)
        {
            List<Token> tokens = new List<Token>();
            for(int i = 0; i < keys.Length; i++)
                if (!String.IsNullOrEmpty(keys[i]) && keys[i].Length != 0 && keys[i][0] != ' ')
                    tokens.Add(new Token(keys[i]));
            return tokens.ToArray<Token>();
        }
    }

    
    public enum TokenType
    {
        INTEGER, DOUBLE, STRING,
        DIM, AS,
        DO, WHILE, LOOP,
        PLUS, MINUS, MULTIPLY, DIVIDE,
        OR, AND, NOT,
        DEGREE,
        PLUS_EQUAL, MINUS_EQUAL, MULTIPLY_EQUAL, DIVIDE_EQUAL,
        EQUAL, MORE, LESS, DONT_EQUAL, LESS_EQUAL, MORE_EQUAL,
        COMMA, DOT, COLON, SEMICOLON,
        LPAR, RPAR,
        UNDERSCORE,
        IDENTIFIER, LITERAL,
        TOKEN_ERROR,
        ENDLINE
    }
    public class Token
    {
        static TokenType[] Delimiters = new TokenType[]
{
            TokenType.PLUS, TokenType.MINUS, TokenType.MULTIPLY,
            TokenType.DIVIDE, TokenType.OR, TokenType.AND, TokenType.DEGREE,
            TokenType.EQUAL, TokenType.MORE, TokenType.LESS,
            TokenType.COMMA, TokenType.DOT, TokenType.COLON,
            TokenType.SEMICOLON, TokenType.LPAR, TokenType.RPAR,
            TokenType.UNDERSCORE, TokenType.NOT
};
        public static Dictionary<string, TokenType> SpecialWords = new Dictionary<string, TokenType>() {
            {"integer", TokenType.INTEGER},
            {"double", TokenType.DOUBLE},
            {"string", TokenType.STRING},
            {"dim", TokenType.DIM},
            {"as", TokenType.AS},
            {"or", TokenType.OR},
            {"and", TokenType.AND},
            {"do", TokenType.DO},
            {"while", TokenType.WHILE},
            {"loop", TokenType.LOOP},
            {"not", TokenType.NOT },

            {"Integer", TokenType.INTEGER},
            {"Double", TokenType.DOUBLE},
            {"String", TokenType.STRING},
            {"Dim", TokenType.DIM},
            {"As", TokenType.AS},
            {"Or", TokenType.OR},
            {"And", TokenType.AND},
            {"Do", TokenType.DO},
            {"While", TokenType.WHILE},
            {"Loop", TokenType.LOOP},
            {"Not", TokenType.NOT }
        };
        public static Dictionary<string, TokenType> SpecialSymbols = new Dictionary<string, TokenType>()
        {
            {"<>", TokenType.DONT_EQUAL},
            {"<=", TokenType.LESS_EQUAL},
            {">=", TokenType.MORE_EQUAL},
            {"+=", TokenType.PLUS_EQUAL},
            {"-=", TokenType.MINUS_EQUAL},
            {"*=", TokenType.MULTIPLY_EQUAL},
            {"/=", TokenType.DIVIDE_EQUAL},
            {"+", TokenType.PLUS},
            {"-", TokenType.MINUS},
            {"*", TokenType.MULTIPLY},
            {"/", TokenType.DIVIDE},
            {"|", TokenType.OR},
            {"^", TokenType.DEGREE},
            {"=", TokenType.EQUAL},
            {">", TokenType.MORE},
            {"<", TokenType.LESS},
            {",", TokenType.COMMA},
            {".", TokenType.DOT},
            {":", TokenType.COLON},
            {";", TokenType.SEMICOLON},
            {"(", TokenType.LPAR},
            {")", TokenType.RPAR},
            {"\n", TokenType.ENDLINE},
            //{'_', TokenType.UNDERSCORE}
        };
        
        
        public TokenType Type;
        public string Value;

        public Token(TokenType type)
        {
            Type = type;
        }

        public Token(string word)
        {

            if (int.TryParse(word, out int a))
            {
                Value = word;
                Type = TokenType.LITERAL;
            }
            else if (IsSpecialSymbol(word)) Type = SpecialSymbols[word];
            else if (IsSpecialWord(word)) Type = SpecialWords[word];
            else if (isIdentifier(word))
            {
                Type = TokenType.IDENTIFIER;
                Value = word;
            }
            else
            {
                Type = TokenType.TOKEN_ERROR;
                Value = word;
            }
        }
        public static bool isIdentifier(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;
            if (
                word[0] >= 65   && word[0] <= 90   || //A-Z
                word[0] >= 97   && word[0] <= 122  || //a-z
                word[0] >= 1040 && word[0] <= 1103 || //А-Я а-я
                word[0] == 'Ё'  || word[0] == 'ё'  || word[0] == '_'
                )
            {
                for(int i = 1; i < word.Length; i++)
                {
                    if (!(
                        word[i] >= 65   && word[i] <= 90   || //A-Z
                        word[i] >= 97   && word[i] <= 122  || //a-z
                        word[i] >= 1040 && word[i] <= 1103 || //А-Я а-я
                        word[i] == 'Ё'  || word[i] == 'ё'  || word[i] == '_' ||
                        word[i] >= 48   && word[i] <= 57   )) //0-9
                        return false;
                }
            }
            else
                return false;
            return true;
        }
        public static bool IsSpecialWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;
            return SpecialWords.ContainsKey(word);
        }
        public static bool IsDelimiter(Token token) => Delimiters.Contains(token.Type);
        public static bool IsSpecialSymbol(string ch) => SpecialSymbols.ContainsKey(ch);
        public override string ToString()
        {
            if(Type == TokenType.TOKEN_ERROR)
                return Value + " - is an identifier with an error";
            if(Value != null)
                return Type + " - " + Value;
            return Type.ToString();
        }
    }
}

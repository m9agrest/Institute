using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work;


public class Parser
{
    private TokenType[] tokens;
    private int currentIndex = 0;

    public Parser(Token[] tokens)
    {

        this.tokens = new TokenType[tokens.Length];
        for(int i = 0; i < tokens.Length; i++)
        {
            this.tokens[i] = tokens[i].Type;
        }
    }

    private void ParseExpression()
    {
        ParseTerm();
        while (currentIndex < tokens.Length && (tokens[currentIndex] == TokenType.AND || tokens[currentIndex] == TokenType.OR))
        {
            ParseTerm();
        }
    }

    private void ParseTerm()
    {
        if (currentIndex < tokens.Length && tokens[currentIndex] == TokenType.NOT)
        {
            currentIndex++;
            ParseFactor();
        }
    }

    private void ParseFactor()
    {
        if (currentIndex < tokens.Length && tokens[currentIndex] == TokenType.LPAR)
        {
            currentIndex++;
            ParseExpression();
            if (currentIndex < tokens.Length && tokens[currentIndex] == TokenType.RPAR)
            {
                currentIndex++;
            }
            else
            {
                throw new Exception("Ошибка: Ожидалась закрывающая скобка.");
            }
        }
        else if (currentIndex < tokens.Length && (tokens[currentIndex] == TokenType.IDENTIFIER || tokens[currentIndex] == TokenType.LITERAL))
        {
            return;
        }
        else
        {
            throw new Exception("Ошибка: Недопустимое выражение.");
        }
    }

    public void Parse()
    {
        ParseExpression();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work;

public class TreeNode
{
    public TokenType Token { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }
}
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
    /*
    private void ParseExpression()
    {
        ParseTerm();
        while (currentIndex < tokens.Length && (
            tokens[currentIndex] == TokenType.AND || 
            tokens[currentIndex] == TokenType.OR ||
            tokens[currentIndex] == TokenType.PLUS ||
            tokens[currentIndex] == TokenType.MINUS ||
            tokens[currentIndex] == TokenType.DIVIDE ||
            tokens[currentIndex] == TokenType.MULTIPLY ||
            tokens[currentIndex] == TokenType.MORE ||
            tokens[currentIndex] == TokenType.LESS ||
            tokens[currentIndex] == TokenType.EQUAL ||
            tokens[currentIndex] == TokenType.DONT_EQUAL

            ))
        {
            ParseTerm();
        }
    }

    private void ParseTerm()
    {
        if (currentIndex < tokens.Length && (
            tokens[currentIndex] == TokenType.NOT || 
            tokens[currentIndex] == TokenType.MINUS || 
            tokens[currentIndex] == TokenType.PLUS))
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
    }*/



    private TreeNode ParseExpression()
    {
        TreeNode left = ParseTerm();
        while (currentIndex < tokens.Length && (
            tokens[currentIndex] == TokenType.AND ||
            tokens[currentIndex] == TokenType.OR ||
            tokens[currentIndex] == TokenType.PLUS ||
            tokens[currentIndex] == TokenType.MINUS ||
            tokens[currentIndex] == TokenType.DIVIDE ||
            tokens[currentIndex] == TokenType.MULTIPLY ||
            tokens[currentIndex] == TokenType.MORE ||
            tokens[currentIndex] == TokenType.LESS ||
            tokens[currentIndex] == TokenType.EQUAL ||
            tokens[currentIndex] == TokenType.DONT_EQUAL))
        {
            TokenType op = tokens[currentIndex++];
            TreeNode right = ParseTerm();
            TreeNode node = new TreeNode { Token = op, Left = left, Right = right };
            left = node;
        }
        return left;
    }

    private TreeNode ParseTerm()
    {
        if (currentIndex < tokens.Length && (
            tokens[currentIndex] == TokenType.NOT ||
            tokens[currentIndex] == TokenType.MINUS ||
            tokens[currentIndex] == TokenType.PLUS))
        {
            TokenType op = tokens[currentIndex++];
            TreeNode operand = ParseFactor();
            return new TreeNode { Token = op, Left = operand };
        }
        return ParseFactor();
    }

    private TreeNode ParseFactor()
    {
        if (currentIndex < tokens.Length && tokens[currentIndex] == TokenType.LPAR)
        {
            currentIndex++;
            TreeNode expression = ParseExpression();
            if (currentIndex < tokens.Length && tokens[currentIndex] == TokenType.RPAR)
            {
                currentIndex++;
                return expression;
            }
            else
            {
                throw new Exception("Ошибка: Ожидалась закрывающая скобка.");
            }
        }
        else if (currentIndex < tokens.Length && (tokens[currentIndex] == TokenType.LITERAL || tokens[currentIndex] == TokenType.IDENTIFIER))
        {
            return new TreeNode { Token = tokens[currentIndex++] };
        }
        else
        {
            throw new Exception("Ошибка: Недопустимое выражение.");
        }
    }

    public TreeNode Parse()
    {
        return ParseExpression();
    }
}

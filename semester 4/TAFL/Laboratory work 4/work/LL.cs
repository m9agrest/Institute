﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public class LL
    {
        List<Token> tokens;
        private List<Token> id;
        Token? Curent(int I) => I < tokens.Count ? tokens[I] : null;
        Token? Previe(int I) => I > 0 ? tokens[I - 1] : null;
        Token? Next(int I) => I < tokens.Count - 1 ? tokens[I + 1] : null;
        
        public LL(Token[] Tokens)
        {
            tokens = new List<Token>();
            id = new List<Token>();
            foreach (Token token in Tokens)
            {
                if (token.Type != TokenType.TOKEN_ERROR)
                {
                    tokens.Add(token);
                }
                else
                {
                    throw new Exception(token.ToString());
                }
            }
        }

        public bool Check()
        {
            return true;
        }


        public int действие(int I)
        {
            Error1(I);
            int r = 0;
            if (операнд(I))
            {
                if (isEndLine(I))
                    return 0;
                I++;
                int sign = знак(I);
                if (sign >= 0)//устраняет любые символы кроме * / - = + <> < >
                    Error2(I, sign == 2);
                if (sign == -2)
                    I++;
                if (sign == -1)
                    r -= 1;
                if (isEndLine(I))
                    return r;
                return r + действие(I + 1);
            }
            else
            {
                int sign = знак(I);
                if(sign == -1)
                {
                    r -= 1;
                    if(isEndLine(I))
                    {
                        return r;
                    }
                }
                else if(isEndLine(I))
                {
                    Error2(I);
                }
                else if(sign == 1)
                {
                    r += 1;
                }
                else if (Curent(I).Type != TokenType.MINUS && Curent(I).Type != TokenType.PLUS)
                {
                    TokenType previe = Previe(I).Type;
                    TokenType next = Next(I).Type;
                    if ((previe == TokenType.RPAR || операнд(I - 1)) && (next == TokenType.LPAR || операнд(I + 1) || next == TokenType.PLUS || next == TokenType.MINUS)) ;
                    else
                        Error2(I);
                }
                I++;
                return r + действие(I);
            }
        }

        private bool isEndLine(int I)
        {
            if (Next(I) == null || Next(I).Type == TokenType.ENDLINE)
                return true;
            return false;
        }
        private int знак(int I)
        {
            Error1(I);
            if (Curent(I).Type == TokenType.MULTIPLY ||
                Curent(I).Type == TokenType.DIVIDE   ||
                Curent(I).Type == TokenType.MINUS    ||
                Curent(I).Type == TokenType.PLUS     ||
                Curent(I).Type == TokenType.MORE     ||
                Curent(I).Type == TokenType.LESS     ||
                Curent(I).Type == TokenType.EQUAL    )
                if (Next(I) != null)
                    if (Curent(I).Type == TokenType.LESS && Next(I).Type == TokenType.MORE) // <>
                        return -2; // <>
                    else if ((Curent(I).Type == TokenType.PLUS     && Next(I).Type == TokenType.EQUAL) || // +=
                             (Curent(I).Type == TokenType.MINUS    && Next(I).Type == TokenType.EQUAL) || // -=
                             (Curent(I).Type == TokenType.DIVIDE   && Next(I).Type == TokenType.EQUAL) || // /=
                             (Curent(I).Type == TokenType.MULTIPLY && Next(I).Type == TokenType.EQUAL) || // *=
                             (Curent(I).Type == TokenType.LESS     && Next(I).Type == TokenType.MORE ))
                        return 2; // += -= *= /=
                    else 
                        return -3;
                else
                    return -3; // + - * / < > =
            if (Curent(I).Type == TokenType.LPAR)
                return 1; // (
            if (Curent(I).Type == TokenType.RPAR)
                return -1; // )
            return 0;
        }
        private bool операнд(int I)
        {
            Error1(I);
            if (Curent(I).Type == TokenType.IDENTIFIER || Curent(I).Type == TokenType.LITERAL)
                return true;
            return false;
        }
        private bool тип(int I)
        {
            Error1(I);
            if (Curent(I) == null)
                return false;
            if (Curent(I).Type == TokenType.DOUBLE ||
                Curent(I).Type == TokenType.INTEGER ||
                Curent(I).Type == TokenType.STRING)
                return true;
            return false;
        }


        private void Error1(int I)
        {
            if (Curent(I) == null)
                throw new Exception("Ожидалось наличие " + (1 + I) + "-ого элемента");
        }

        private void Error2(int I) => Error2(I, false, null);
        private void Error2(int I, bool next) => Error2(I, next, null);
        private void Error2(int I, TokenType[] TokenTypes) => Error2(I, false, TokenTypes);
        private void Error2(int I, bool next, TokenType[] TokenTypes)
        {
            Error1(I);
            if(TokenTypes != null && TokenTypes.Length != 0)
            {
                string err = "(";
                for (int i = 0; i < TokenTypes.Length; i++)
                {
                    err += TokenTypes[i].ToString();
                    if (i + 1 < TokenTypes.Length)
                        err += ", ";
                }
                err += ")";
                if (next)
                {
                    Error1(I + 1);
                    throw new Exception((1 + I) + " и " + (2 + I) + " элементов (" + Curent(I) + " и " + Curent(I + 1) + "), ожидалось " + err);
                }
                throw new Exception("Вместо " + (1 + I) + "-ого элемента (" + Curent(I) + "), ожидалось " + err);
            }
            if(next)
            {
                Error1(I+1);
                throw new Exception((1 + I) + " и " + (2 + I) + " элемент (" + Curent(I) + " и " + Curent(I+1) + "), не ожидался");
            }
            throw new Exception((1 + I) + "-ый элемент (" + Curent(I) + "), не ожидался");
        }
    }
}
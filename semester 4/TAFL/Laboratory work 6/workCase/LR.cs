﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public class LR
    {
        List<Token> tokens;

        Token _Curent()
        {
            Error1();
            return Curent();
        }
        Token _CurentUp()
        {
            i++;
            Error1();
            return Curent();
        }


        Token? Curent() => i < tokens.Count ? tokens[i] : null;
        Token? Previe() => i > 0 ? tokens[i - 1] : null;
        Token? Next() => i < tokens.Count - 1 ? tokens[i + 1] : null;
        
        public LR(Token[] Tokens)
        {
            tokens = new List<Token>();
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
        int i;
        public void Check()
        {
            i = 0;
            while (i != -1)
                _1();
        }

        void _1()
        {
            if(i != -1)
            {
                if(Curent() == null)
                {
                    i = -1;
                }
                else
                    switch(Curent().Type)
                    {
                        case TokenType.DIM:
                            _16();
                            break;
                        case TokenType.IDENTIFIER:
                            _4();
                            break;
                        case TokenType.SELECT:
                            _25();
                            break;
                        case TokenType.ENDLINE:
                            i++;
                            break;
                        default:
                            Error2();
                            break;
                    }
            }
        }

        void _4()
        {
            _CurentUp();
            if(Curent().Type == TokenType.EQUAL)
                _5();
            else if (Curent().Type == TokenType.PLUS     ||
                     Curent().Type == TokenType.MINUS    ||
                     Curent().Type == TokenType.MULTIPLY ||
                     Curent().Type == TokenType.DIVIDE)
            {
                _CurentUp();
                if (Curent().Type == TokenType.EQUAL)
                    _5();
                else Error2();
            } else Error2();
        }
        void _5()
        {
            while(Curent() != null && Curent().Type != TokenType.ENDLINE)
                i++;
        }

        void _16()
        {
            _CurentUp();
            if(Curent().Type == TokenType.IDENTIFIER)
            {
                _CurentUp();
                if (Curent().Type == TokenType.COMMA)
                    _16();
                else if (Curent().Type == TokenType.AS)
                    _18();
                else Error2();
            } else Error2();
        }
        void _18()
        {
            _CurentUp();
            if (Curent().Type == TokenType.INTEGER ||
               Curent().Type == TokenType.DOUBLE ||
               Curent().Type == TokenType.STRING)
                i++;
            else Error2();
        }
        void _25()
        {
            if(_CurentUp().Type == TokenType.CASE)
            {
                if (_CurentUp().Type == TokenType.IDENTIFIER)
                {
                    if (_CurentUp().Type == TokenType.ENDLINE)
                    {
                        while (Curent() != null && Curent().Type != TokenType.END)
                            _28();
                        _Curent();
                        if (_CurentUp().Type != TokenType.SELECT) Error2();
                        i++;

                    } else Error2();
                } else Error2();
            } else Error2();
        }
        void _28()
        {
            if(_CurentUp().Type == TokenType.CASE)
            {
                _CurentUp();
                if (Curent().Type == TokenType.LITERAL)
                {
                    if(_CurentUp().Type == TokenType.ENDLINE)
                    {
                        _28x(false);
                    }
                    else if(Curent().Type == TokenType.TO)
                    {
                        if (_CurentUp().Type == TokenType.LITERAL && _CurentUp().Type == TokenType.ENDLINE)
                        {
                            _28x(false);
                        } else Error2();
                    } else Error2();
                }
                else if(Curent().Type == TokenType.ELSE && _CurentUp().Type == TokenType.ENDLINE)
                {
                    _28x(true);
                } else Error2();
            } else Error2();
        }
        void _28x(bool end)
        {
            while (Curent() != null && Curent().Type != TokenType.CASE && Curent().Type != TokenType.END)
                _1();
            if(_Curent().Type == TokenType.CASE)
            {
                if (end) Error2();
                i--;
            }
            else if(Curent().Type != TokenType.END) Error2();
        }

        private void Error1()
        {
            if (Curent() == null)
                throw new Exception("Ожидалось наличие " + (1 + i) + "-ого элемента");
        }
        private void Error2() => Error2(i);
        private void Error2(int I) => Error2(I, false, null);
        private void Error2(int I, bool next) => Error2(I, next, null);
        private void Error2(int I, TokenType[] TokenTypes) => Error2(I, false, TokenTypes);
        private void Error2(int I, bool next, TokenType[] TokenTypes)
        {
            Error1();
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
                    Error1();
                    throw new Exception((1 + I) + " и " + (2 + I) + " элементов (" + Curent() + " и " + Curent() + "), ожидалось " + err);
                }
                throw new Exception("Вместо " + (1 + I) + "-ого элемента (" + Curent() + "), ожидалось " + err);
            }
            if(next)
            {
                Error1();
                throw new Exception((1 + I) + " и " + (2 + I) + " элемент (" + Curent() + " и " + Curent() + "), не ожидался");
            }
            throw new Exception((1 + I) + "-ый элемент (" + Curent() + "), не ожидался");
        }
    }
}

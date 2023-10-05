using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private bool isCurent() => Curent() != null;

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
                if(!isCurent())
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
                        case TokenType.DO:
                            _25();
                            break;
                        case TokenType.ENDLINE:
                            i++;
                            break;
                        default:
                            Error2(TokenType.DIM, TokenType.IDENTIFIER, TokenType.DO, TokenType.ENDLINE);
                            break;
                    }
            }
        }

        void _4()
        {
            _CurentUp();
            if(Curent().Type == TokenType.EQUAL || 
                Curent().Type == TokenType.PLUS_EQUAL ||
                Curent().Type == TokenType.MINUS_EQUAL ||
                Curent().Type == TokenType.MULTIPLY_EQUAL ||
                Curent().Type == TokenType.DIVIDE_EQUAL)
                _5();
            else Error2(TokenType.EQUAL, TokenType.PLUS_EQUAL, TokenType.MINUS_EQUAL, TokenType.MULTIPLY_EQUAL, TokenType.DIVIDE_EQUAL);
        }
        void _5()
        {
            _CurentUp();
            if(Curent().Type == TokenType.IDENTIFIER || Curent().Type == TokenType.LITERAL)
            {
                i++;
                if(Curent() != null)
                {
                    if (Curent().Type == TokenType.PLUS ||
                        Curent().Type == TokenType.MINUS ||
                        Curent().Type == TokenType.MULTIPLY ||
                        Curent().Type == TokenType.DIVIDE)
                    {
                        _5();
                    }
                    else if (Curent().Type == TokenType.ENDLINE)
                        i++;
                    else Error2(TokenType.PLUS, TokenType.MINUS, TokenType.MULTIPLY, TokenType.DIVIDE);
                }
            } else Error2(TokenType.IDENTIFIER, TokenType.LITERAL);
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
                else Error2(TokenType.COMMA, TokenType.AS);
            } else Error2(TokenType.IDENTIFIER);
        }
        void _18()
        {
            _CurentUp();
            if (Curent().Type == TokenType.INTEGER ||
               Curent().Type == TokenType.DOUBLE ||
               Curent().Type == TokenType.STRING)
                i++;
            else Error2(TokenType.INTEGER, TokenType.DOUBLE, TokenType.STRING);
        }
        void _25()
        {
            if(_CurentUp().Type == TokenType.WHILE)
            {
                expr();
                _CurentUp();
                while (Curent() != null && Curent().Type != TokenType.LOOP)
                    _1();
                if (Curent() == null)
                    Error2(TokenType.LOOP);
                i++;
            } else Error2(TokenType.WHILE);
        }

        public List<Troyka> Troyka = new List<Troyka>();
        Bower bower;
        void expr()
        {

            List<Token> t = new List<Token>();
            i++;
            while(Curent() != null && Curent().Type != TokenType.ENDLINE)
            {
                t.Add(Curent());
                i++;
            }
            if(bower == null)
                bower = new Bower(t);
            else
                bower = new Bower(t, bower.Lastindex);
            bower.troyka = Troyka;
            bower.Start();

            _Curent();
        }

        #region Ошибки
        private void Error1()
        {
            if (Curent() == null)
                throw new Exception(GetLine(i) + " Строка, Ожидалось наличие " + (1 + i) + "-ого элемента");
        }
        private void Error2() => Error2(i, false, null);
        private void Error2(params TokenType[] TokenTypes) => Error2(i, false, TokenTypes);
        private void Error2(int I) => Error2(I, false, null);
        private void Error2(int I, bool next) => Error2(I, next, null);
        private void Error2(int I, params TokenType[] TokenTypes) => Error2(I, false, TokenTypes);
        private void Error2(int I, bool next, params TokenType[] TokenTypes)
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
                    throw new Exception(GetLine(I) + " Строка, " + (1 + I) + " и " + (2 + I) + " элементов (" + Curent() + " и " + Curent() + "), ожидалось " + err);
                }
                throw new Exception(GetLine(I) + " Строка, " + "Вместо " + (1 + I) + "-ого элемента (" + Curent() + "), ожидалось " + err);
            }
            if(next)
            {
                Error1();
                throw new Exception(GetLine(I) + " Строка, " + (1 + I) + " и " + (2 + I) + " элемент (" + Curent() + " и " + Curent() + "), не ожидался");
            }
            throw new Exception(GetLine(I) + " Строка, " + (1 + I) + "-ый элемент (" + Curent() + "), не ожидался");
        }
        int GetLine(int I)
        {
            int L = 1;
            for (int Li = 0; Li < I && Li < tokens.Count; Li++)
            {
                if (tokens[Li].Type == TokenType.ENDLINE)
                    L++;
            }
            return L;
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace coursework_TAiFYA
{
    public class lexemes
    {
        public enum Symbol
        {
            Letter,
            Liters,
            Separator,
            Space,
            Other
        }
        public enum TypeLexeme
        {
            I,
            L,
            R
        }

        private List<string> separators_list = new List<string>()
        {
            "+","++", "-","--", "*", "/", "=","==", ";", ".", ",", "(", ")", "<", ">", "{","}"
        };

        private Symbol GetSymbol(char symbol)
        {
            if (char.IsLetter(symbol))
            {
                return Symbol.Letter;
            }
            else if (char.IsDigit(symbol))
            {
                return Symbol.Liters;
            }
            else if (separators_list.Contains(symbol.ToString()) || symbol == '\n')
            {
                return Symbol.Separator;
            }
            else if (symbol == ' ')
            {
                return Symbol.Space;
            }
            return Symbol.Other;
        }

        public List<Tuple<string, TypeLexeme>> Check(string text)
        {
            List<Tuple<string, TypeLexeme>> lexems = new List<Tuple<string, TypeLexeme>>();
            string buffer = "";
            TypeLexeme tl = TypeLexeme.I;

            for (int i = 0; i < text.Length; i++)
            {
			
                if (tl == TypeLexeme.I && buffer.Length > 8)
                {
                    throw new Exception("Длина идентификатора превысила 8 символов");
                }

                switch (GetSymbol(text[i]))
                {
                    case Symbol.Letter:

                        if (buffer == " ")
                        {
                            tl = TypeLexeme.I;
                            buffer += text[i];
                            break;
                        }

                        switch (tl)
                        {
                            case TypeLexeme.I:
                                buffer += text[i];
								break;

							case TypeLexeme.L:
								throw new Exception("Наименование не может начинаться с цифр");

                            case TypeLexeme.R:
                                lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl));
                                buffer = text[i].ToString();
                                tl = TypeLexeme.I;
                                break;
                        }
                        break;

                    case Symbol.Liters:

                        if (buffer == "")
                        {
                            tl = TypeLexeme.L;
                            buffer += text[i];
                            break;
                        }

                        switch (tl)
                        {
                            case TypeLexeme.I:
                                buffer += text[i];
                                break;

                            case TypeLexeme.L:
                                buffer += text[i];
                                break;

                            case TypeLexeme.R:
                                lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl));
                                buffer = text[i].ToString();
                                tl = TypeLexeme.L;
                                break;
                        }
                        break;

                    case Symbol.Separator: 

                        if (buffer == "")
                        {
                            tl = TypeLexeme.R;
                            buffer += text[i];
                            break;
                        }

                        switch (tl)
                        {
                            case TypeLexeme.I:
                                lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl));
                                buffer = text[i].ToString();
                                tl = TypeLexeme.R;
                                break;

                            case TypeLexeme.L:
                                lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl));
                                buffer = text[i].ToString();
                                tl = TypeLexeme.R;
                                break;

                            case TypeLexeme.R:
                                if (buffer.Length > 3)
                                {
                                    throw new Exception("Длина разделителя не может превышать два символа");
                                }
                                buffer += text[i];
                                tl = TypeLexeme.R;
                                break;
                        }
                        break;

                    case Symbol.Space:

						if (buffer.Length == 0)
						{
							break;
						}
                        lexems.Add(new Tuple<string, TypeLexeme>(buffer, tl));
                        buffer = "";
                        break;

                    case Symbol.Other:
                        throw new Exception("Недопустимые символы в программе");
                }
            }

            switch (tl)
            {
                case TypeLexeme.I:
                    lexems.Add(new Tuple<string, TypeLexeme>(buffer, TypeLexeme.I));
                    break;

                case TypeLexeme.L:
                    lexems.Add(new Tuple<string, TypeLexeme>(buffer, TypeLexeme.L));
                    break;

                case TypeLexeme.R:
                    lexems.Add(new Tuple<string, TypeLexeme>(buffer, TypeLexeme.R));
                    break;
            }

            return lexems;
        }
    }
}

using System;
using System.Collections.Generic;
using static coursework_TAiFYA.lexemes;


namespace coursework_TAiFYA
{
    public class lemexeClass
    {
        public readonly List<string> keywords = new List<string>()
        {
           "main", "int", "for", "char", "string"
        };

        public readonly List<string> separators_list = new List<string>()
        {
          "++", "+", "-","--", "*", "/", "=","==", ";", ".", ",", "(", ")", "<", ">", "{","}"
        };

        public readonly List<string> identifiers = new List<string>();
        public readonly List<string> literals = new List<string>();

        public List<Tuple<string, int>> Classify(List<Tuple<string, TypeLexeme>> lexemes)
        {
            List<Tuple<string, int>> result = new List<Tuple<string, int>>();


            foreach (var lexem in lexemes)
            {
                string lexemStr = lexem.Item1;
                TypeLexeme lexemType = lexem.Item2;

                switch (lexemType)
                {
                    case TypeLexeme.I:
                        if (keywords.Contains(lexemStr))
                        {
                            result.Add(new Tuple<string, int>("Ключевое слово", keywords.IndexOf(lexemStr)));
                        }
                        else
                        {
                            if (!identifiers.Contains(lexemStr))
                            {
                                identifiers.Add(lexemStr);
                            }

                            result.Add(new Tuple<string, int>("Индификаторы", identifiers.IndexOf(lexemStr)));
                        }

                        break;

                    case TypeLexeme.L:
                        if (!literals.Contains(lexemStr))
                        {
                            literals.Add(lexemStr);
                        }

                        result.Add(new Tuple<string, int>("Литерал", literals.IndexOf(lexemStr)));
                        break;

                    case TypeLexeme.R:
                        if (separators_list.Contains(lexemStr))
                        {
                            result.Add(new Tuple<string, int>("Разделитель", separators_list.IndexOf(lexemStr)));
                        }
                        break;
                }
            }

            return result;
        }
    }
}

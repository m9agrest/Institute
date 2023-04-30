using System;
using System.Collections.Generic;

namespace work
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            NonSpaceAndTab("""
                using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.Text;
                using System.Threading.Tasks;

                namespace ConsoleApp2
                {
                    internal class Program
                    {
                        static void Main(string[] args)
                        {
                            string a = "asd      asd", b = "erew      ", d, e = "243", f, g;
                            d = a + "           wdwdwdwd";
                            f = e + a;
                            g = d + f;
                        }
                    }
                }
                """);
        }



        static string[] NonSpaceAndTab(string arg)
        {
            string[] lex =
            {
                "using",
                "int",
                "float",
                "double",
                "long",
                "float",
                "short",
                "bool",
                ""
            };
            string Code = "STRINGBYID";
            List<string> ret = new List<string>();
            ret.Add("");
            int I = 0;
            bool write = false;
            for (int i = 0; i < arg.Length; i++)
                if (write)
                    if (arg[i] != '\"')
                        ret[I] += arg[i];
                    else// if(i != 0 && arg[i - 1] != '\\')
                        write = false;
                else if (arg[i] == '\"')
                {
                    write = true;
                    I++;
                    ret.Add("");
                    ret[0] += (Code + I);
                }
                else if(arg[i] != ' ' && arg[i] != '\t')
                    ret[0] += arg[i];
            Console.WriteLine("Code\n" + ret[0] + "\n\n\n");
            for (int i = 1; i < ret.Count; i++)
                Console.WriteLine("STRINGBYID" + i + ": \"" + ret[i] + "\"");
            return ret.ToArray();
        }
    }
}
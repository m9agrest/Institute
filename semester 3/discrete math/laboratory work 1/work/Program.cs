using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //test();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        static void test()
        {
            string[] a = { "4", "2", "3", "1", "2", "1", "4", "2", "8" };
            string[] b = { "5", "6", "3", "5", "4", "1", "3", "7" };
            write("A[]", a);
            write("B[]", b);
            write("Remove(A[])", Operation.Remove(a));
            write("Remove(B[])", Operation.Remove(b));
            write("Объедение A и B", Operation.Union(a, b));
            write("Пересечение A и B", Operation.Intersection(a, b));
            write("Разность A от B", Operation.Difference(a, b));
            write("Разность B от A", Operation.Difference(b, a));
        }
        static void write(string t, string[] a)
        {
            Console.Write($"{t}: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.Write("\n");
        }
    }
}

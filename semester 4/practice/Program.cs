using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Formats.Tar;
using WebSocketSharp;

namespace practice
{
    internal static class Program
    {
        public const string PathDirectoryData = "Data";
        public const string PathDirectoryDataFile = PathDirectoryData + "\\File";
        public const string PathConfig = PathDirectoryData + "\\Config.json";
        public static FormMain form;

        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(PathDirectoryData)) // ��������, ���� �� ����� ��� �������� ����������
            {
                Directory.CreateDirectory(PathDirectoryData); // �������� ����� ��� �������� ����������
            }
            if(!Directory.Exists(PathDirectoryDataFile)) // ��������, ���� �� ����� ��� �������� ������
            {
                Directory.CreateDirectory(PathDirectoryDataFile); // �������� ����� ��� �������� ������
            }
            Config.Load(PathConfig);

            
            form = new FormMain(Config.Type <= 0);
            if (Config.Type > 0)
            {
                Server.Start();
            }
            else
            {
                Client.Start();
            }
            Application.Run();
        }




        public static void Restart()
        {
            //Application.Restart(); - �� ������ �����������
            Process.Start(Application.ExecutablePath);
            Environment.Exit(0);
        }
        public static void Exit()
        {
            string[] files = Directory.GetFiles(PathDirectoryDataFile);
            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch(Exception) { }
            }
            Environment.Exit(0);
        }

    }
}
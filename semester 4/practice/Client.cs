using Newtonsoft.Json.Linq;
using practice;
using System.Diagnostics;
using WebSocketSharp;

static class Client
{
    static WebSocket webSocket;
    static string file = null;
    public static void Start()
    {
        if(webSocket != null && webSocket.IsAlive)
        {
            webSocket.Close();
        }
        webSocket = new WebSocket($"ws://192.168.1.110:{Config.Port}/{Config.Service}");
        webSocket.OnMessage += (sender, e) => Task(e);
        webSocket.Connect();
        Send(new JObject() { { "Type", "Connect" }, { "Name", Config.Name } }.ToString());
    }
    public static void Send(string text)
    {
        if (webSocket != null)
            webSocket.Send(text);
        else
            Start();
    }
    static void Task(MessageEventArgs e)
    {
        if(e.IsText)
        {
            Task(e.Data);
        }
        else if(e.IsBinary)
        {
            File.WriteAllBytes(Program.PathDirectoryDataFile + "/" + file, e.RawData);
            Open();
        }
    }
    static void Open()
    {
        string type = file.Split('.').Last();
        string path = "\"" + AppDomain.CurrentDomain.BaseDirectory + Program.PathDirectoryDataFile + "\\" + file + "\"";
        if (Config.Files.ContainsKey(type))
        {
            try
            {
                Process.Start(Config.Files[type], path);
            }
            catch (Exception)
            {
                Process.Start("explorer", path);
            }
        }
        else
        {
            Process.Start("explorer", path);
        }
        file = null;
    }
    static void Task(string task)
    {
        try
        {
            JObject json = JObject.Parse(task);
            switch ((string)json["Type"])
            {
                case "Update":
                    Config.Update((JObject)json["JSON"]);
                    break;
                case "FileUpdate":
                    Config.FilesUpdate((string)json["Key"], (string)json["Path"]);
                    break;
                case "FileAdd":
                    Config.FilesAdd((string)json["Key"], (string)json["Path"]);
                    break;
                case "FileRemote":
                    Config.FilesRemote((string)json["Key"]);
                    break;
                case "NameUpdate":
                    Config.NameUpdate((string)json["Name"]);
                    break;
                case "AppRestart":
                    Program.Restart();
                    break;
                case "AppClose":
                    Program.Exit();
                    break;
                case "FileOpen":
                    file = (string)json["File"];
                    if (File.Exists(Program.PathDirectoryDataFile + "/" + file))
                        Open();
                    else
                        Send(new JObject() { { "Type", "Download" }, { "File", file } }.ToString());
                    break;
                case "FileDelete":
                    File.Delete(Program.PathDirectoryDataFile + "/" + (string)json["File"]);
                    break;
            }
        }
        catch(Exception) { }
        
    }
}

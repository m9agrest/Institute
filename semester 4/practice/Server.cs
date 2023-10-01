using Newtonsoft.Json.Linq;
using practice;
using System.Net;
using WebSocketSharp;
using WebSocketSharp.Server;

class Server : WebSocketBehavior
{
    static Dictionary<string, string> files = new Dictionary<string, string>();
    public static int MaxClients = 0;
    public static Dictionary<int, ClientInfo> Clients = new Dictionary<int, ClientInfo>();
    static WebSocketServer webSocketServer;

    public static string GetFile(string path)
    {
        if(files.ContainsValue(path))
        {
            foreach(KeyValuePair<string, string> file in files)
            {
                if (file.Value == path)
                {
                    return file.Key;
                }
            }
        }
        string name = Convert.ToString(DateTime.Now.Ticks, 16) + '.' + path.Split('.').Last();
        files.Add(name, path);
        return name;
    }


    public static void ClientClose(CloseEventArgs e, WebSocket WebSocket)
    {
        int IdClose = -1;
        foreach (KeyValuePair<int, ClientInfo> client in Server.Clients)
        {
            if (client.Value.WebSocket == WebSocket)
            {
                IdClose = client.Key;
                break;
            }
        }
        if(IdClose >= 0 && Clients.Remove(IdClose))
        {
            Program.form.UpdateUI();
        }
    }
    public static void ClientAdd(WebSocket WebSocket, string Name)
    {
        if(MaxClients <= Clients.Count)
        {
            MaxClients = Clients.Count;
            Clients.Add(MaxClients++, new ClientInfo(WebSocket, Name));
        }
        else
        {
            for(int i = 0; i < MaxClients; i++)
            {
                if(!Clients.ContainsKey(i))
                {
                    Clients.Add(i, new ClientInfo(WebSocket, Name));
                    break;
                }
            }
        }
        Program.form.UpdateUI();
    }
    public static void Start()
    {
        webSocketServer = new WebSocketServer($"ws://127.0.0.1:{Config.Port}");
        webSocketServer.AddWebSocketService<Server>($"/{Config.Service}");
        webSocketServer.Start();
    }
    public static void Stop() => webSocketServer.Stop();
    public static void SendMessage(string msg) => webSocketServer.WebSocketServices.Broadcast(msg);
    public static void SendMessage(int id, string msg)
    {
        if(Clients.ContainsKey(id))
        {
            Clients[id].WebSocket.Send(msg);
        }
    }
    public static void SendMessage(int[] ids, string msg)
    {
        foreach(int id in ids)
        {
            SendMessage(id, msg);
        }
    }
    protected override void OnMessage(MessageEventArgs e)
    {
        try
        {
            JObject json = JObject.Parse(e.Data);
            switch ((string)json["Type"])
            {
                case "Connect":
                    ClientAdd(Context.WebSocket, (string)json["Name"]);
                    Context.WebSocket.OnClose += (sender, e) => ClientClose(e, Context.WebSocket);
                    break;
                case "Download":
                    byte[] data = File.ReadAllBytes(files[(string)json["File"]]);
                    Send(data);
                    break;
            }
        }
        catch (Exception) { }
    }
}
class ClientInfo
{
    public WebSocket WebSocket;
    public string Name;
    public ClientInfo(WebSocket WebSocket, string Name)
    {
        this.WebSocket = WebSocket;
        this.Name = Name;
    }
}
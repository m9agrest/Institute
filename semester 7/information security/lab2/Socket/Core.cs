using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;




public abstract class Core
{

    private protected Socket socket;
    private IPHostEntry ipHost;
    private IPAddress ipAddr;
    private protected IPEndPoint ipEndPoint;
    private protected Thread waitingForMessage;


    private string host;
    private int port;
    private protected Button bServer;
    private protected Button bClient;
    private Button bSend;
    private protected ListBox listLog;
    public Core(string host, int port, Button bServer, Button bClient, Button bSend, ListBox listLog)
    {
        this.host = host;
        this.port = port;
        this.bServer = bServer;
        this.bClient = bClient;
        this.listLog = listLog;
    }
    public void Open()
    {
        ipHost = Dns.Resolve(host);
        for (int i = 0; i < ipHost.AddressList.Length; i++)
        {
            listLog.Invoke(new Action(() =>
            {
                listLog.Items.Add("Попытка: " + (i + 1) + "/" + ipHost.AddressList.Length);
            }));
            ipAddr = ipHost.AddressList[i];
            ipEndPoint = new IPEndPoint(ipAddr, port);


            try
            {
                socket = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp);
                if (OpenNext())
                {
                    waitingForMessage = new Thread(new ParameterizedThreadStart(GetMessages));
                    waitingForMessage.Start();
                    return;
                }
            }
            catch (Exception ex)
            {
                listLog.Invoke(new Action(() =>
                {
                    listLog.Items.Add("Error:" + ex.Message);
                }));
                continue;
            }
        }
        bServer.Invoke(new Action(() => {
            bServer.BackColor = Color.Transparent;
            bServer.Enabled = true;
        }));
        bClient.Invoke(new Action(() => {
            bClient.BackColor = Color.Transparent;
            bClient.Enabled = true;
        }));
    }

    private void GetMessages(object? obj)
    {
        while (true)
        {
            Thread.Sleep(50);
            try
            {
                string Message = GetData();
                listLog.Invoke(new Action(() =>
                    listLog.Items.Add(DateTime.Now.ToShortTimeString() + " Get: " + Message)));
            } catch { }
        }
    }



    private string GetData()
    {
        string GetInformation = "";
        byte[] GetBytes = new byte[1024];
        int BytesRec = socket.Receive(GetBytes);
        GetInformation += Encoding.Unicode.GetString(GetBytes, 0, BytesRec);
        return GetInformation;
    }
    public void Send(string data)
    {
        byte[] SendMsg = Encoding.Unicode.GetBytes(data);
        socket.Send(SendMsg);
    }



    private protected virtual bool OpenNext(){
        return false;
    }
}

using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
public class Server : Core
{

    public Server(string host, int port, Button bServer, Button bClient, Button bSend, ListBox listLog)
        : base(host, port, bServer, bClient, bSend, listLog)
    {

    }


    private protected override bool OpenNext()
    {
        try
        {
            socket.Bind(ipEndPoint);
            socket.Listen(10);
            while (true)
            {
                Socket A = socket.Accept();
                if (A.Connected)
                {
                    bServer.Invoke(new Action(() => bServer.BackColor = Color.Green));
                    socket = A;
                    return true;
                }
            }
        }
        catch (Exception e)
        {

            listLog.Invoke(new Action(() =>
            {
                listLog.Items.Add("Error:" + e.Message);
            }));
            return false;
        }
    }

}

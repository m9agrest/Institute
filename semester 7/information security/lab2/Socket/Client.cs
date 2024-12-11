public class Client : Core
{
    public Client(string host, int port, Button bServer, Button bClient, Button bSend, ListBox listLog)
        : base(host, port, bServer, bClient, bSend, listLog)
    {

    }



    private protected override bool OpenNext()
    {
        while (true)
        {
            socket.Connect(ipEndPoint);
            if (socket.Connected)
            {
                bClient.Invoke(new Action(() => bClient.BackColor = Color.Green));
                return true;
            }
        }
    }

}

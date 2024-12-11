
using System.Net;
using System.Windows.Forms;
using System;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    Core core;
    private Thread socketThread;
    private void bServer_Click(object sender, EventArgs e)
    {
        bClient.BackColor = Color.Red;
        bClient.Enabled = false;
        bServer.BackColor = Color.Orange;
        bServer.Enabled = false;
        core = new Server(iIP.Text, (int)iPort.Value, bServer, bClient, bSend, listLog);
        Open();
    }

    private void bClient_Click(object sender, EventArgs e)
    {
        bClient.BackColor = Color.Orange;
        bClient.Enabled = false;
        bServer.BackColor = Color.Red;
        bServer.Enabled = false;
        core = new Client(iIP.Text, (int)iPort.Value, bServer, bClient, bSend, listLog);
        Open();
    }
    private void Open()
    {
        socketThread = new Thread(new ThreadStart(core.Open));
        socketThread.IsBackground = true;
        socketThread.Start();
    }


    private void bSend_Click(object sender, EventArgs e)
    {
        if (iMSG.Text.Length > 0)
        {
            core.Send(iMSG.Text);
        }
    }
}

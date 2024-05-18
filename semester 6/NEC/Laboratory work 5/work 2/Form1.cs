using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Text;
using System.Windows.Forms;
namespace work_2
{
    public partial class Form1 : Form
    {
        private static Socket Client; // ������� ������ ������-�������
        private static IPHostEntry ipHost; // ����� ��� �������� �� ������ ���-����
        private static IPAddress ipAddr; // ������������� IP-�����
        private static IPEndPoint ipEndPoint; // ��������� �������� �����
        private static Thread socketThread; // ������� ����� ��� ��������� ������
        private static Thread WaitingForMessage; // ������� ����� ��� ����� ���������

        private void startSocket()
        {
            // IP-����� �������, ��� �����������
            string HostName = InputIP.Text;
            // ���� �����������
            string Port = InputPort.Text;
            // ��������� DNS-��� ���� ��� IP-����� � ��������� IPHostEntry.
            ipHost = Dns.Resolve(HostName);
            // �������� �� ������ ������� ������ (������� ����� ���� �����)
            ipAddr = ipHost.AddressList[4];
            // ������� �������� ��������� ����� ����������� �� �����-�� �����
            ipEndPoint = new IPEndPoint(ipAddr, int.Parse(Port));
            try
            {
                // ������� ����� �� ������� ������
                Client = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
                while (true)
                {
                    // �������� ������������ � ��������� �����
                    Client.Connect(ipEndPoint);
                    if (Client.Connected) // ���� ������ �����������
                    {
                        // ��������� �������� ��� �������, ����� ������������ ����, ��� ���������� �����������
                        buttonConnect.Invoke(new Action(() => buttonConnect.Text = "����������� �����������"));
                        buttonConnect.Invoke(new Action(() => buttonConnect.BackColor = Color.Green));
                        // ������� ����� �����, ��������� �� �-��� ��������� ��������� � ������ Worker
                     WaitingForMessage = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(GetMessages));
                        // ���������, � ���������� �������� �������� (������� ����)
                        WaitingForMessage.Start(new Object[] { listBox1 });
                    }
                    break;
                }
            }
            catch (SocketException error)
            {
                // 10061 � ���� ����������� �����/������
                if (error.ErrorCode == 10061)
                {
                    MessageBox.Show("���� ����������� ������!");
                    Application.Exit();
                }
            }
        }

        // �-���, ���������� � ����� ������: ��������� ����� �������� ����
        public static void GetMessages(Object obj)
        {
            // �������� ������ ������� ���� (���� ����)
            Object[] Temp = (Object[])obj;
            ListBox ChatListBox = (ListBox)Temp[0];
            // � ����������� ����� �������� ���������
            while (true)
            {
                // ������ �����, ����� �� ����� ����������� ���� ��� �������� ���������
                Thread.Sleep(50);
                try
                {
                    string Message = GetDataFromServer();
                    ChatListBox.Invoke(new Action(() => {
                        string[] Arr = Message.Split("\n");
                        if (Arr.Length > 0)
                        {
                            ChatListBox.Items.Add(DateTime.Now.ToShortTimeString() + " �����:");
                            foreach (string str in Arr)
                            {
                                ChatListBox.Items.Add(str);
                            }
                        }
                        else
                        {
                            ChatListBox.Items.Add(DateTime.Now.ToShortTimeString() + " � ������ ��� �����!");
                        }
                    }));
                }
                catch { }
            }
        }

        // ��������� ������ �� �������
        public static string GetDataFromServer()
        {
            string GetInformation = "";
            // ������� ������ ���������� ������, ���� ����� �������� ����������
            byte[] GetBytes = new byte[1024];
            int BytesRec = Client.Receive(GetBytes);
            // ��������� �� ������� ����� � ������
            GetInformation += Encoding.Unicode.GetString(GetBytes, 0, BytesRec);
            return GetInformation;
        }













        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            socketThread = new Thread(new ThreadStart(startSocket));
            socketThread.IsBackground = true;
            socketThread.Start();
            buttonConnect.Enabled = false;
            buttonConnect.Text = "�������� �����������";
            buttonConnect.BackColor = Color.Yellow;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendDataToServer(InputText.Text);
            // ��������� � ������� ���� �� ��������� + ��� + ����� ���������

            listBox1.Items.Add(DateTime.Now.ToShortTimeString() + " ������ ���������!");
            // ������������� ������� ����
            listBox1.TopIndex = listBox1.Items.Count - 1;
            // ������� ����� �� ���� �����
            InputText.Text = "";
        }

        // �������� ���������� �� ������
        public static void SendDataToServer(string Data)
        {
            // ���������� unicode, ����� �� ���� ������� � ����������, ��� ������ ����������
            byte[] SendMsg = Encoding.Unicode.GetBytes(Data);
            Client.Send(SendMsg);
        }

        private void InputPort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace Laboratory_work_5
{
    public partial class Form1 : Form
    {
        // ������ ���������� ����������
        private static Socket Server; // ������� ������ ������-�������
        private static Socket Handler; // ������� ������ ���������������� ������
        private static IPHostEntry ipHost; // ����� ��� �������� �� ������ ���-����
        private static IPAddress ipAddr; // ������������� IP-�����
        private static IPEndPoint ipEndPoint; // ��������� �������� �����
        private static Thread socketThread; // ������� ����� ��� ��������� ������
        private static Thread WaitingForMessage; // ������� ����� ��� ����� ���������

        // ������� ������� ������
        private void startSocket()
        {
            // IP-����� �������, ��� �����������
            string HostName = "0.0.0.0";
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
                // ������� ����� ������� �� ������� ������
                Server = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
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
            // ���� �����������
            try
            {
                // ��������� ��������� ����� � �������
                Server.Bind(ipEndPoint);
                // �� ����� 10 ����������� �� �����
                Server.Listen(10);
                // �������� "������������" �����������
                while (true)
                {
                    Handler = Server.Accept();
                    if (Handler.Connected)
                    {
                        // ��������� �������� ��� �������, ����� ������������ ����, ��� ���������� �����������
                        buttonConnect.Invoke(new Action(() => buttonConnect.Text = "������ ���������"));
                        buttonConnect.Invoke(new Action(() => buttonConnect.BackColor = Color.Green));
                        // ������� ����� �����, ��������� �� �-��� ��������� ��������� � ������ Worker
                        WaitingForMessage = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(GetMessages));
                        // ���������, � ���������� �������� �������� (������� ����)
                        WaitingForMessage.Start(new Object[] { listBox1 });
                    }
                    break;
                }
            }
            catch (Exception e)
            {
                throw new Exception("�������� � ������������");
            }
        }

        // �-���, ���������� � ����� ������: ��������� ����� ��������� ����
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
                    // �������� ��������� �� �������
                    string Message = GetDataFromClient();
                    // ��������� � ������� + ������� �����
                    ChatListBox.Invoke(new Action(() =>
                    ChatListBox.Items.Add(DateTime.Now.ToShortTimeString() + " ������� ������ �� �������")));


                    string[] Arr = Message.Split("\n");
                    if(Arr.Length > 1 && Arr.Last().Length == 1)
                    {
                        StringBuilder stringBuilder= new StringBuilder();
                        for(int i = 0; i < Arr.Length - 1; i++)
                        {
                            if (Arr[i].Length > 0 && Arr[i][0] != Arr.Last()[0])
                            {
                                stringBuilder.Append(Arr[i]);
                                stringBuilder.Append("\n");
                            }
                        }
                        SendDataToClient(stringBuilder.ToString());
                    }
                    else
                    {
                        SendDataToClient(Message);
                    }
                }
                catch { }

            }
        }

        // ��������� ���������� �� �������
        public static string GetDataFromClient()
        {
            string GetInformation = "";
            byte[] GetBytes = new byte[1024];
            int BytesRec = Handler.Receive(GetBytes);
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
            /*SendDataToClient(InputText.Text);
            // ��������� � ������� ���� �� ��������� + ��� + ����� ���������
            listBox1.Items.Add(DateTime.Now.ToShortTimeString() + " Server: " +
            InputText.Text.ToString());
            // ������������� ������� ����
            listBox1.TopIndex = listBox1.Items.Count - 1;
            // ������� ����� �� ���� �����
            InputText.Text = "";*/
        }

        // �������� ���������� �� ������
        public static void SendDataToClient(string Data)
        {
            byte[] SendMsg = Encoding.Unicode.GetBytes(Data);
            Handler.Send(SendMsg);
        }
    }
}
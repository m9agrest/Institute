using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace Laboratory_work_5
{
    public partial class Form1 : Form
    {
        // Раздел глобальных переменных
        private static Socket Server; // Создаем объект сокета-сервера
        private static Socket Handler; // Создаем объект вспомогательного сокета
        private static IPHostEntry ipHost; // Класс для сведений об адресе веб-узла
        private static IPAddress ipAddr; // Предоставляет IP-адрес
        private static IPEndPoint ipEndPoint; // Локальная конечная точка
        private static Thread socketThread; // Создаем поток для поддержки потока
        private static Thread WaitingForMessage; // Создаем поток для приёма сообщений

        // Функция запуска сокета
        private void startSocket()
        {
            // IP-адрес сервера, для подключения
            string HostName = "0.0.0.0";
            // Порт подключения
            string Port = InputPort.Text;
            // Разрешает DNS-имя узла или IP-адрес в экземпляр IPHostEntry.
            ipHost = Dns.Resolve(HostName);
            // Получаем из списка адресов первый (адресов может быть много)
            ipAddr = ipHost.AddressList[4];
            // Создаем конечную локальную точку подключения на каком-то порту
            ipEndPoint = new IPEndPoint(ipAddr, int.Parse(Port));
            try
            {
                // Создаем сокет сервера на текущей машине
                Server = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            }
            catch (SocketException error)
            {
                // 10061 — порт подключения занят/закрыт
                if (error.ErrorCode == 10061)
                {
                    MessageBox.Show("Порт подключения закрыт!");
                    Application.Exit();
                }
            }
            // Ждем подключений
            try
            {
                // Связываем удаленную точку с сокетом
                Server.Bind(ipEndPoint);
                // Не более 10 подключения на сокет
                Server.Listen(10);
                // Начинаем "прослушивать" подключения
                while (true)
                {
                    Handler = Server.Accept();
                    if (Handler.Connected)
                    {
                        // Позеленим кнопочку для красоты, чтобы пользователь знал, что соединение установлено
                        buttonConnect.Invoke(new Action(() => buttonConnect.Text = "Клиент подключен"));
                        buttonConnect.Invoke(new Action(() => buttonConnect.BackColor = Color.Green));
                        // Создаем новый поток, указываем на ф-цию получения сообщений в классе Worker
                        WaitingForMessage = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(GetMessages));
                        // Запускаем, в параметрах передаем листбокс (история чата)
                        WaitingForMessage.Start(new Object[] { listBox1 });
                    }
                    break;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Проблемы с подключением");
            }
        }

        // Ф-ция, работающая в новом потоке: получение новых сообщений ————
        public static void GetMessages(Object obj)
        {
            // Получаем объект истории чата (лист бокс)
            Object[] Temp = (Object[])obj;
            ListBox ChatListBox = (ListBox)Temp[0];
            // В бесконечном цикле получаем сообщения
            while (true)
            {
                // Ставим паузу, чтобы на время освобождать порт для отправки сообщений
                Thread.Sleep(50);
                try
                {
                    // Получаем сообщение от клиента
                    string Message = GetDataFromClient();
                    // Добавляем в историю + текущее время
                    ChatListBox.Invoke(new Action(() =>
                    ChatListBox.Items.Add(DateTime.Now.ToShortTimeString() + " Получен запрос от клиента")));


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

        // Получение информации от клиента
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
            buttonConnect.Text = "Ожидание подключения";
            buttonConnect.BackColor = Color.Yellow;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            /*SendDataToClient(InputText.Text);
            // Добавляем в историю свое же сообщение + ник + время написания
            listBox1.Items.Add(DateTime.Now.ToShortTimeString() + " Server: " +
            InputText.Text.ToString());
            // Автопрокрутка истории чата
            listBox1.TopIndex = listBox1.Items.Count - 1;
            // Убираем текст из поля ввода
            InputText.Text = "";*/
        }

        // Отправка информации на клиент
        public static void SendDataToClient(string Data)
        {
            byte[] SendMsg = Encoding.Unicode.GetBytes(Data);
            Handler.Send(SendMsg);
        }
    }
}
using Newtonsoft.Json.Linq;
using practice.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice
{
    public partial class FormMain : Form
    {
        Form formSetting;
        private readonly SynchronizationContext syncContext;
        public FormMain(bool isClient)
        {
            InitializeComponent();
            formSetting = new FormSetting();
            if (isClient)
            {
                Hide();
                notifyIcon.ContextMenuStrip = contextMenuStripClient;
            }
            else
            {
                Show();
                notifyIcon.ContextMenuStrip = contextMenuStripServer;
                syncContext = SynchronizationContext.Current;
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            Hide();
        }
        public void UpdateUI() => syncContext.Post(UpdateUI, null);

        private void UpdateUI(object? content)
        {
            for (; blocks.Count < Server.MaxClients;
                blocks.Add(new Block(PanelGroup))) ;
            for(int i = 0; i < Server.MaxClients; i++)
            {
                if(Server.Clients.ContainsKey(i))
                {
                    blocks[i].StatusConnect(true);
                    blocks[i].UpdateName(Server.Clients[i].Name);
                }
                else
                {
                    blocks[i].StatusConnect(false);
                    blocks[i].UpdateName("");
                }
            }
        }
        List<Block> blocks = new List<Block>();





        private void showToolStripMenuItem_Click(object sender, EventArgs e) => Show();
        private void hideToolStripMenuItem_Click(object sender, EventArgs e) => Hide();
        private void settingToolStripMenuItem_Click(object sender, EventArgs e) => formSetting.Show();
        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e) => Client.Start();
        private void restartToolStripMenuItem_Click(object sender, EventArgs e) => Program.Restart();
        private void closeToolStripMenuItem_Click(object sender, EventArgs e) => Program.Exit();
        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            foreach(Block block in blocks) 
            {
                block.Select(true);
            }
        }
        private void buttonRemoveSelection_Click(object? sender, EventArgs? e)
        {
            foreach (Block block in blocks)
            {
                block.Select(false);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select the file that will open on the selected computers";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = Server.GetFile(dialog.FileName);
                Send(new JObject() { { "Type", "FileOpen" }, { "File", file } }.ToString());
            }
        }
        private void buttonRestart_Click(object sender, EventArgs e) =>Send(new JObject() { { "Type", "AppRestart" } }.ToString());
        private void buttonClose_Click(object sender, EventArgs e) => Send(new JObject() { { "Type", "AppClose" } }.ToString());
        private void Send(string msg)
        {
            foreach (KeyValuePair<int, ClientInfo> client in Server.Clients)
            {
                if (blocks[client.Key].isSelect)
                {
                    Server.SendMessage(client.Key, msg);
                }
            }
            buttonRemoveSelection_Click(null, null);
        }
    }
}

class Block
{
    Panel Box;
    PictureBox Picture;
    Label Name;
    Label Status;
    bool select = false;
    public bool isSelect => select;
    public void Select() => Select(!select);
    public void Select(bool select)
    {
        this.select = select;
        if (select)
        {
            Box.BorderStyle = BorderStyle.Fixed3D;
        }
        else
        {
            Box.BorderStyle = BorderStyle.None;
        }
    }
    public Block(FlowLayoutPanel flow)
    {

        Box = new Panel();
        Box.Width = 100;
        Box.Height = 100;

        Picture = new PictureBox();
        Picture.Image = Resources.computer;
        Picture.SizeMode = PictureBoxSizeMode.Zoom;
        Picture.Width = 70;
        Picture.Height = 70;
        Box.Controls.Add(Picture);
        Picture.Left = 15;
        Picture.Top = 0;

        Name = new Label();
        Name.Text = "";
        Box.Controls.Add(Name);
        Name.ForeColor = Color.Black;
        Name.Font = new Font(Name.Font.FontFamily, 12);
        Name.Top = 75;
        Name.Left = 0;

        Status = new Label();
        Status.Text = "⚫";
        Status.Font = Name.Font;
        StatusConnect(true);
        Box.Controls.Add(Status);

        flow.Controls.Add(Box);



        Box.MouseDown += (s, e) => Select();
        Status.MouseDown += (s, e) => Select();
        Picture.MouseDown += (s, e) => Select();
        Name.MouseDown += (s, e) => Select();
    }
    public void UpdateName(string name)
    {
        Name.Text = name;
    }
    public void StatusConnect(bool Connect)
    {
        if(Connect)
        {
            Status.ForeColor = Color.Green;
        }
        else
        {
            Status.ForeColor = Color.Red;
        }
    }
}
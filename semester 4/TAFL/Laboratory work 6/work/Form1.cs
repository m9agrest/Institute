using System.Windows.Forms;

namespace work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Файлы txt (*.txt)|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader rdr = new StreamReader(fileDialog.FileName);
                string line = rdr.ReadToEnd();
                rdr.Close();
                richTextBox1.Text = line;
                Tokens(null, null);
            }
        }

        private void Tokens(object sender, EventArgs e)
        {
            code(richTextBox1.Text);
        }
        void code(string code)
        {
            listBox1.Items.Clear();
            Token[] tokens = generation.Tokens(generation.Split(code));
            foreach (Token token in tokens)
            {
                listBox1.Items.Add(token);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Token[] tokens = generation.Tokens(generation.Split(richTextBox1.Text));
            listBox1.Items.Clear();
            /*LL a = new LL(tokens);
            listBox1.Items.Clear();
            listBox1.Items.Add(a.действие(0));*/
            try
            {
                LR a = new LR(tokens);
                a.Check();
                listBox1.Items.Add("Проверено успешно");
            }
            catch(Exception E)
            {
                listBox1.Items.Add(E.ToString());
            }

        }
    }
}
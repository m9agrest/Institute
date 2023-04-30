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
            fileDialog.Filter = "װאיכû txt (*.txt)|*.txt";
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
    }
}
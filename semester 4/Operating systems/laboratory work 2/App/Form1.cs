using System.Diagnostics;
using System.Threading.Channels;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fileName;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "װאיכû bat (*.bat)|*.bat";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(fileName != null)
            {
                Process MyProcess = new Process();
                MyProcess.StartInfo.FileName = fileName;
                MyProcess.Start();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work
{
    public partial class FormProcessesInfo : Form
    {
        public FormProcessesInfo()
        {
            InitializeComponent();
            listBoxProcesses.Items.Clear();
            foreach (Process process in Process.GetProcesses())
            {
                listBoxProcesses.Items.Add(new ProcessInfo(process));
            }
        }
        private void listBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxProcesses.SelectedIndex;
            try
            {
                ((ProcessInfo)listBoxProcesses.Items[index]).Info(listBoxProcess);
            }
            catch { }
        }
    }
}

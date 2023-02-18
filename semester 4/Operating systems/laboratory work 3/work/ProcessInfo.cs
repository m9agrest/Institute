using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work
{
    internal class ProcessInfo
    {
        public Process process;
        public ProcessInfo(Process process) 
        {
            this.process = process;
        }
        public void Info(ListBox listBox)
        {
            listBox.Items.Clear();
            try
            {
                listBox.Items.Add("Id:  " +process.Id.ToString());
                listBox.Items.Add("SessionId:  " + process.SessionId.ToString());
                listBox.Items.Add("ProcessName:  " + process.ProcessName.ToString());
                listBox.Items.Add("MachineName:  " + process.MachineName.ToString());
                listBox.Items.Add("StartTime:  " + process.StartTime.ToString());
                listBox.Items.Add("MemorySize:  " + ((int)(process.PrivateMemorySize64 / (1024 * 102.4)) / 10.0).ToString() + " mb");
                listBox.Items.Add("Modules:");
                for(int i = 0; i < process.Modules.Count; i++)
                {
                    listBox.Items.Add("  " + process.Modules[i].ToString());
                }
            }
            catch { }
        }
        public override string ToString() => String.Format($"{process.Id,-9} {process.ProcessName}");
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct task
        {
            public int id;
            public int cpu_time;
            public int hdd_time;
            public int lan_time;
        }
        task[] mas_tasks;

        private void buttonGen_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            mas_tasks = new task[Convert.ToInt32(textBoxN.Text)];
            for (int i = 0; i < Convert.ToInt32(textBoxN.Text); i++)
            {
                mas_tasks[i].id = i + 1;
                mas_tasks[i].cpu_time = Convert.ToInt32(textBoxk.Text) - Convert.ToInt32(textBoxl.Text) + rnd.Next(Convert.ToInt32(textBoxl.Text) * 2);
                mas_tasks[i].hdd_time = Convert.ToInt32(textBoxm.Text) - Convert.ToInt32(textBoxv.Text) + rnd.Next(Convert.ToInt32(textBoxv.Text) * 2);
                mas_tasks[i].lan_time = Convert.ToInt32(textBoxb.Text) - Convert.ToInt32(textBoxd.Text) + rnd.Next(Convert.ToInt32(textBoxd.Text) * 2);
            }
            richTextBoxGen.Clear();
            for (int i = 0; i < Convert.ToInt32(textBoxN.Text); i++)
            {
                if (i < 9)
                    richTextBoxGen.Text += "0" + mas_tasks[i].id + " " + mas_tasks[i].cpu_time + " " + mas_tasks[i].hdd_time + " " + mas_tasks[i].lan_time + "\n";
                else
                    richTextBoxGen.Text += mas_tasks[i].id + " " + mas_tasks[i].cpu_time + " " + mas_tasks[i].hdd_time + " " + mas_tasks[i].lan_time + "\n";
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(textBoxN.Text) - 1; i++)
            {
                for (int j = i + 1; j < Convert.ToInt32(textBoxN.Text); j++)
                {
                    if (mas_tasks[i].cpu_time < mas_tasks[j].cpu_time)
                    {
                        task temp = mas_tasks[i];
                        mas_tasks[i] = mas_tasks[j];
                        mas_tasks[j] = temp;
                    }
                }
            }
            richTextBoxSort.Clear();
            for (int i = 0; i < Convert.ToInt32(textBoxN.Text); i++)
            {
                if (mas_tasks[i].id < 10)
                    richTextBoxSort.Text += "0" + mas_tasks[i].id + " " + mas_tasks[i].cpu_time + " " + mas_tasks[i].hdd_time + " " + mas_tasks[i].lan_time + "\n";
                else
                    richTextBoxSort.Text += mas_tasks[i].id + " " + mas_tasks[i].cpu_time + " " + mas_tasks[i].hdd_time + " " + mas_tasks[i].lan_time + "\n";
            }
        }

        private void buttonProc_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool cpu = true;
            bool hdd = true;
            bool lan = true;
            int cpu_current = 0;
            int hdd_busy_time = 0;
            int lan_busy_time = 0;
            if (cpu)
            {
                for (int i = 0; i < Convert.ToInt32(textBoxN.Text); i++)
                {
                    if (mas_tasks[i].cpu_time > 0)
                    {
                        cpu = false;
                        cpu_current = i;
                        break;
                    }
                }
            }
            if (!cpu)
            {
                mas_tasks[cpu_current].cpu_time--;
            }
            if (!cpu && mas_tasks[cpu_current].cpu_time == 0)
            {
                cpu = true;
            }
            if (hdd)
            {
                for (int i = 0; i < Convert.ToInt32(textBoxN.Text); i++)
                {
                    if (mas_tasks[i].hdd_time + mas_tasks[i].cpu_time > 0)
                    {
                        hdd = false;
                        hdd_busy_time = cpu_current = i;
                        break;
                    }
                }
            }
            if (!hdd && mas_tasks[cpu_current].cpu_time == 0)
            {
                mas_tasks[hdd_busy_time].hdd_time--;
            }
            if (!hdd && mas_tasks[hdd_busy_time].hdd_time == 0)
            {
                hdd = true;
            }
            if (lan)
            {
                for (int i = 0; i < Convert.ToInt32(textBoxN.Text); i++)
                {
                    if (mas_tasks[i].lan_time + mas_tasks[i].hdd_time > 0)
                    {
                        lan = false;
                        lan_busy_time = hdd_busy_time = i;
                        break;
                    }
                }
            }
            if (!lan && mas_tasks[hdd_busy_time].hdd_time == 0)
            {
                mas_tasks[lan_busy_time].lan_time--;
            }
            if (!lan && mas_tasks[lan_busy_time].lan_time == 0)
            {
                lan = true;
            }
            richTextBoxSort.Clear();
            for (int i = 0; i < Convert.ToInt32(textBoxN.Text); i++)
            {
                if (mas_tasks[i].id < 10)
                    richTextBoxSort.Text += "0" + mas_tasks[i].id + " " + mas_tasks[i].cpu_time + " " + mas_tasks[i].hdd_time + " " + mas_tasks[i].lan_time + "\n";
                else
                    richTextBoxSort.Text += mas_tasks[i].id + " " + mas_tasks[i].cpu_time + " " + mas_tasks[i].hdd_time + " " + mas_tasks[i].lan_time + "\n";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    public partial class Window : Form
    {

        DataBase dataBase;
        public Window(string name)
        {
            dataBase = new DataBase(name);
            InitializeComponent();
        }

        private void buttonTableCreate_Click(object sender, EventArgs e)
        {
            string a = textBoxTable.Text;
            if (a == "" || a == null) return;
            if(!dataBase.CreateTable(a))
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonTableOpen_Click(object sender, EventArgs e)
        {
            string a = textBoxTable.Text;
            if (a == "" || a == null) return;
            string[,] data = dataBase.GetTable(a);
            if(data == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                dataGridView1.Columns.Clear();
                for(int i = 0; i < data.GetLength(1); i++)
                {
                    dataGridView1.Columns.Add(data[0, i], data[0, i]);
                }
                /*for(int j = 1; j < data.GetLength(0); j++)
                {
                    for (int i = 0; i < data.GetLength(1); i++)
                    {
                        dataGridView1.Rows[j].Cells.Add(data[i, j], );//Columns.Add(data[0, i], data[0, i]);
                    }
                }*/
            }
        }

        private void buttonColumnCreate_Click(object sender, EventArgs e)
        {
            string a = textBoxTable.Text;
            string b = textBoxColumn.Text;
            if (a == "" || a == null || b == "" || b == null) return;
            if (!dataBase.AddColumnForTable(a, b))
            {
                MessageBox.Show("Error");
            }
            else
            {
                dataGridView1.Columns.Add(b, b);
            }
        }
    }
}

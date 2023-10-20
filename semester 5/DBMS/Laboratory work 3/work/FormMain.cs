using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work
{
    public partial class FormMain : Form
    {
        NpgsqlConnection? connection = null;
        public FormMain()
        {
            InitializeComponent();
            buttonAdd.Visible = false;
            buttonEdit.Visible = false;
            Connection("localhost", 5432, "postgres", "0", "postgres");
        }
        public void Connection(string server, ushort port, string user, string password, string database)
        {
            Disconnect();
            connection = new NpgsqlConnection($"Port={port};Server={server};Database={database};User Id={user};Password={password};");
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show( 
                    "Ошибка", 
                    "Соеденение не установлено!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
            
        }
        public void Disconnect()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                try
                {
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show(
                        "Ошибка",
                        "Предыдущее соеденение не смогло корректно закрыться!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void closing(object sender, FormClosingEventArgs e) => Disconnect();

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            buttonAdd.Visible = true;
            buttonEdit.Visible = true;
        }
        private void buttonUser_Click(object sender, EventArgs e)
        {
            buttonAdd.Visible = false;
            buttonEdit.Visible = false;
        }
        private void buttonUpdateList_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
